using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Inventory.Core;
using Inventory.Model;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Controllers
{
    public class CategoriesController
    {
        private readonly ICategoryRepository repository;
        private readonly IUnitOfWorkFactory uowFactory;

        public CategoriesController()
        {
            uowFactory = new NHibernateUnitOfWorkFactory(context);
            repository = CategoryRepository.GetInstance(context);
        }

        public CategoriesController(IUnitOfWorkFactory uowFactory, ICategoryRepository repository)
        {
            this.uowFactory = uowFactory;
            this.repository = repository;
        }

        private ISession context => NHibernateSessionProvider.GetSession();

        public List<Category> Index()
        {
            return repository.GetAll().ToList();
        }

        public Category Details(int Id)
        {
            return repository.GetAll().Single(x => x.Id == Id);
        }

        public void Create(Category entity)
        {
            using (var uow = uowFactory.Create())
            {
                repository.Add(entity);
                uow.Save();
            }
        }

        public void Edit(Category entity)
        {
            using (var uow = uowFactory.Create())
            {
                var original = repository.GetByKey(entity.Id);
                original.Id = entity.Id;
                original.Name = entity.Name;

                uow.Save();
            }
        }

        public void Delete(int Id)
        {
            using (var uow = uowFactory.Create())
            {
                repository.Remove(repository.GetByKey(Id));
                uow.Save();
            }
        }

        internal void Create(IAddNewCategoryView inForm)
        {
            if (inForm.Display(repository.GetAll().ToList()))
                try
                {
                    var category = CategoryFactory.CreateCategory(inForm.CategoryName, inForm.ParentCategory);
                    Create(category);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
        }

        private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source,
            Expression<Func<TSource, TKey>> keySelector, bool ascending)
        {
            return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }
    }
}
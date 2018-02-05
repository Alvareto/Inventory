using System;
using System.Collections.Generic;
using System.Linq;
using Inventory;
using Inventory.Core;
using Inventory.Model;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Controllers
{
    public class CategoriesController
    {
        private IUnitOfWorkFactory uowFactory;
        private ICategoryRepository repository;

        private ISession context => NHibernateSessionProvider.GetSession();

        public CategoriesController()
        {
            this.uowFactory = new NHibernateUnitOfWorkFactory(context);
            this.repository = CategoryRepository.GetInstance(context);
        }

        public CategoriesController(IUnitOfWorkFactory uowFactory, ICategoryRepository repository)
        {
            this.uowFactory = uowFactory;
            this.repository = repository;
        }

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
            using (IUnitOfWork uow = uowFactory.Create())
            {
                repository.Add(entity);
                uow.Save();
            }
        }

        public void Edit(Category entity)
        {
            using (IUnitOfWork uow = uowFactory.Create())
            {
                Category original = repository.GetByKey(entity.Id);
                original.Id = entity.Id;
                original.Name = entity.Name;

                uow.Save();
            }
        }

        public void Delete(int Id)
        {
            using (IUnitOfWork uow = uowFactory.Create())
            {
                repository.Remove(repository.GetByKey(Id));
                uow.Save();
            }
        }

        internal void Create(IAddNewCategoryView inForm)
        {
            if (inForm.Display(repository.GetAll().ToList()))
            {
                try
                {
                    var category = CategoryFactory.CreateCategory(inForm.CategoryName, inForm.ParentCategory);
                    this.Create(category);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }

        private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, System.Linq.Expressions.Expression<Func<TSource, TKey>> keySelector, bool ascending)
        {

            return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }
    }
}


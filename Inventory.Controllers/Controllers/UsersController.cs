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
    public class UsersController
    {
        private readonly IUserRepository repository;
        private readonly IUnitOfWorkFactory uowFactory;

        public UsersController()
        {
            uowFactory = new NHibernateUnitOfWorkFactory(context);
            repository = UserRepository.GetInstance(context);
        }

        public UsersController(IUnitOfWorkFactory uowFactory, IUserRepository repository)
        {
            this.uowFactory = uowFactory;
            this.repository = repository;
        }

        private ISession context => NHibernateSessionProvider.GetSession();

        private List<User> Index()
        {
            return repository.GetAll().ToList();
        }

        public void Index(IShowUserListView inForm, IMainFormController mainController)
        {
            inForm.Display(mainController, Index());
        }

        private void Create(User entity)
        {
            using (var uow = uowFactory.Create())
            {
                repository.Add(entity);
                uow.Save();
            }
        }

        public void Create(IAddNewUserView inForm)
        {
            if (inForm.Display())
                try
                {
                    Create(UserFactory.CreateUser(inForm.FirstName, inForm.LastName, inForm.DateHired));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
        }

        private User Details(int Id)
        {
            return repository.GetByKey(Id);
        }

        private void Edit(User entity)
        {
            using (var uow = uowFactory.Create())
            {
                var original = repository.GetByKey(entity.Id);
                original.Id = entity.Id;
                original.FirstName = entity.FirstName;
                original.LastName = entity.LastName;
                original.DateHired = entity.DateHired;
                original.DateFired = entity.DateFired;
                uow.Save();
            }
        }

        private void Delete(int Id)
        {
            using (var uow = uowFactory.Create())
            {
                repository.Remove(repository.GetByKey(Id));
                uow.Save();
            }
        }

        private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source,
            Expression<Func<TSource, TKey>> keySelector, bool ascending)
        {
            return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }

        public void Deactivate(IDeactivateUserView inForm)
        {
            if (inForm.Display(Index()))
            {
                var entity = inForm.SelectedUser;
                entity.Active = false;
                entity.DateFired = inForm.DateFired;

                Edit(entity);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Core;
using Inventory.Model;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Controllers
{
    public class EquipmentsController
    {
        private IUnitOfWorkFactory uowFactory;
        private IEquipmentRepository repository;
        private ICategoryRepository categoryRepository;
        public ISession context => NHibernateSessionProvider.GetSession(); // can we make this per form session?

        public EquipmentsController()
        {
            //var context = NHibernateSessionProvider.GetSession();
            var _session = context;
            this.uowFactory = new NHibernateUnitOfWorkFactory(context);
            this.repository = EquipmentRepository.GetInstance(_session);
            this.categoryRepository = CategoryRepository.GetInstance(_session);
        }

        public EquipmentsController(IUnitOfWorkFactory uowFactory, IEquipmentRepository repository, ICategoryRepository categoryRepository)
        {
            this.uowFactory = uowFactory;
            this.repository = repository;
            this.categoryRepository = categoryRepository;
        }

        private List<Equipment> Index()
        {
            return repository.GetAll().ToList();
        }

        private void Create(Equipment entity)
        {
            using (IUnitOfWork uow = uowFactory.Create())
            {
                repository.Add(entity);
                uow.Save();
            }
        }

        internal void Index(IShowEquipmentListView inForm, MainFormController mainController)
        {
            inForm.Display(mainController, repository.GetAll().ToList());
        }

        public Equipment Details(int Id)
        {
            return repository.GetByKey(Id);
        }

        public void Edit(Equipment entity)
        {
            using (IUnitOfWork uow = uowFactory.Create())
            {
                Equipment original = repository.GetByKey(entity.Id);
                original.Id = entity.Id;
                original.Active = entity.Active;
                original.DateAcquired = entity.DateAcquired;
                original.DateDisposed = entity.DateDisposed;
                uow.Save();
            }
        }

        public void Create(IAddNewEquipmentView inForm, IUserRepository userRepository)
        {
            if (inForm.Display(categoryRepository.GetAll().ToList()))
            {
                try
                {
                    using (IUnitOfWork uow = uowFactory.Create())
                    {
                        userRepository = UserRepository.GetInstance(context);
                        // make sure that administrator user gets created and "assigned"
                        var user = userRepository.GetAll()
                            .FirstOrDefault(u => u.LastName == Constants.ADMINISTRATOR_LASTNAME);

                        if (user == null)
                        {
                            user = UserFactory.CreateDefaultUser(Constants.ADMINISTRATOR_LASTNAME);

                            userRepository.Add(user);
                            //uow.Save();
                        }

                        var entity = EquipmentFactory.CreateEquipment(inForm.EquipmentName, inForm.EquipmentCategory, inForm.DateAcquired);
                        var inventory = InventoryFactory.CreateInventory(entity, user, entity.DateAcquired);
                        entity.Users.Add(inventory);

                        repository.Add(entity);
                        uow.Save();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
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

        private static IOrderedQueryable<TSource> OrderBy<TSource, TKey>(IQueryable<TSource> source, System.Linq.Expressions.Expression<Func<TSource, TKey>> keySelector, bool ascending)
        {

            return ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
        }

        public void Dispose(IDisposeEquipmentView frm)
        {
            if (frm.Display(this.Index()))
            {
                var entity = frm.SelectedEquipment;
                entity.Active = false; // dispose
                entity.DateDisposed = frm.DateDisposed;

                this.Edit(entity);
            }
        }
    }
}


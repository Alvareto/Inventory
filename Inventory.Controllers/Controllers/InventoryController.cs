using System;
using System.Collections.Generic;
using System.Linq;
using Inventory.Core;
using Inventory.Model;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Controllers
{
    public class InventoryController : IInventoryController
    {
        private readonly IUnitOfWorkFactory _uowFactory = null;
        private readonly IUserRepository _userRepository = null;
        private readonly IEquipmentRepository _equipmentRepository = null;
        private readonly IInventoryRepository _inventoryRepository = null;
        private ISession context => NHibernateSessionProvider.GetSession();

        public InventoryController()
        {
            this._uowFactory = new NHibernateUnitOfWorkFactory(context);
            this._equipmentRepository = EquipmentRepository.GetInstance(context);
            this._userRepository = UserRepository.GetInstance(context);
            this._inventoryRepository = InventoryRepository.GetInstance(context);
        }

        public InventoryController(IUnitOfWorkFactory uowFactory, IUserRepository inUserRepo, IEquipmentRepository inEquipmentRepo)
        {
            this._uowFactory = uowFactory;
            this._userRepository = inUserRepo;
            this._equipmentRepository = inEquipmentRepo;
            this._inventoryRepository = InventoryRepository.GetInstance(context);
        }


        public void Assign(IAssignEquipmentView inForm)
        {
            if (inForm.Display(_equipmentRepository.GetAll().ToList(), _userRepository.GetAllActive().ToList()))
            {
                try
                {
                    // when assigning - we have to actually transfer from current equipment assignment (company) to new user
                    using (IUnitOfWork uow = _uowFactory.Create())
                    {
                        var user = inForm.SelectedUser;

                        var equipment = inForm.SelectedEquipment;

                        var oldInventory = _inventoryRepository.GetLatest(equipment);
                        oldInventory.DateTo = inForm.DateFrom;

                        var inventory = InventoryFactory.CreateInventory(equipment, user, inForm.DateFrom);
                        equipment.Users.Add(inventory);

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

        public void Return()
        {

        }

        public void Transfer(ITransferEquipmentView inForm)
        {
            if (inForm.Display(_equipmentRepository.GetAll().ToList()
                , _userRepository.GetAllActive().ToList()
                , null))// _equipmentRepository.MapInventory()))
            {
                try
                {
                    using (IUnitOfWork uow = _uowFactory.Create())
                    {
                        var user = inForm.SelectedUserTo;

                        var equipment = inForm.SelectedTransferEquipment;

                        var oldInventory = equipment.CurrentInventory;
                        oldInventory.DateTo = inForm.Date_ExTo_NewFrom;

                        var inventory = InventoryFactory.CreateInventory(equipment, user, inForm.Date_ExTo_NewFrom);
                        equipment.Users.Add(inventory);

                        uow.Save();
                    }

                    //todo var category = CategoryFactory.CreateCategory(inForm.CategoryName, inForm.ParentCategory);
                    //this.Create(category);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
        }
    }
}

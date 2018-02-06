using System;
using System.Linq;
using Inventory.Core;
using Inventory.Model;
using Inventory.SQLiteDAL;
using NHibernate;

namespace Inventory.Controllers
{
    public class InventoryController : IInventoryController
    {
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly IUserRepository _userRepository;

        public InventoryController()
        {
            _uowFactory = new NHibernateUnitOfWorkFactory(context);
            _equipmentRepository = EquipmentRepository.GetInstance(context);
            _userRepository = UserRepository.GetInstance(context);
            _inventoryRepository = InventoryRepository.GetInstance(context);
        }

        public InventoryController(IUnitOfWorkFactory uowFactory, IUserRepository inUserRepo,
            IEquipmentRepository inEquipmentRepo)
        {
            _uowFactory = uowFactory;
            _userRepository = inUserRepo;
            _equipmentRepository = inEquipmentRepo;
            _inventoryRepository = InventoryRepository.GetInstance(context);
        }

        private ISession context => NHibernateSessionProvider.GetSession();


        public void Assign(IAssignEquipmentView inForm)
        {
            if (inForm.Display(_equipmentRepository.GetAll().ToList(), _userRepository.GetAllActive().ToList()))
                try
                {
                    // when assigning - we have to actually transfer from current equipment assignment (company) to new user
                    using (var uow = _uowFactory.Create())
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

        public void Transfer(ITransferEquipmentView inForm)
        {
            if (inForm.Display(_equipmentRepository.GetAll().ToList()
                , _userRepository.GetAllActive().ToList()))
                try
                {
                    using (var uow = _uowFactory.Create())
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

        public void Return()
        {
        }
    }
}
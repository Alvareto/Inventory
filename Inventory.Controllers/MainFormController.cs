using System;
using Inventory.Core;

namespace Inventory.Controllers
{
    public class MainFormController : IMainFormController
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IEquipmentRepository _equipmentRepository;
        private readonly IWindowFormsFactory _formsFactory;
        private readonly IUnitOfWorkFactory _uowFactory;
        private readonly IUserRepository _userRepository;

        public MainFormController()
        {
        }

        public MainFormController(IWindowFormsFactory inFormFactory, IUnitOfWorkFactory uowFactory,
            IUserRepository inUserRepo, IEquipmentRepository inEquipmentRepo, ICategoryRepository inCategoryRepo)
        {
            _formsFactory = inFormFactory;
            _uowFactory = uowFactory;
            _userRepository = inUserRepo;
            _equipmentRepository = inEquipmentRepo;
            _categoryRepository = inCategoryRepo;
        }

        public void AddUser()
        {
            var _ctrl = new UsersController();

            var _frm = _formsFactory.CreateAddNewUserView();

            _ctrl.Create(_frm);
        }

        public void AddEquipment()
        {
            var _ctrl = new EquipmentsController(); // _uowFactory, _equipmentRepository

            var _frm = _formsFactory.CreateAddNewEquipmentView();

            _ctrl.Create(_frm, _userRepository);
        }

        public void AssignEquipment()
        {
            var _ctrl = new InventoryController();

            var _frm = _formsFactory.CreateAssignEquipmentView();

            _ctrl.Assign(_frm);
        }

        public void TransferEquipment()
        {
            var _ctrl = new InventoryController();

            var _frm = _formsFactory.CreateTransferEquipmentView();

            _ctrl.Transfer(_frm);
        }

        public void DeactivateUser()
        {
            var _ctrl = new UsersController();

            var _frm = _formsFactory.CreateDeactivateUserView();

            _ctrl.Deactivate(_frm);
        }

        public void DisposeEquipment()
        {
            var _ctrl = new EquipmentsController();

            var _frm = _formsFactory.CreateDisposeEquipmentView();

            _ctrl.Dispose(_frm);
        }

        public void AddCategory()
        {
            var _ctrl = new CategoriesController();

            var _frm = _formsFactory.CreateAddNewCategoryView();

            _ctrl.Create(_frm);
        }

        public void ShowUsers()
        {
            var _ctrl = new UsersController();

            var _frm = _formsFactory.CreateShowUsersListView();

            _ctrl.Index(_frm, this);
        }

        public void ShowInventory()
        {
            var _ctrl = new EquipmentsController(); // _uowFactory, _equipmentRepository

            var _frm = _formsFactory.CreateShowEquipmentListView();

            _ctrl.Index(_frm, this);
        }

        public void ShowUserInventory()
        {
            throw new NotImplementedException();
        }

        public void ShowEquipmentUsers()
        {
            throw new NotImplementedException();
        }
    }
}
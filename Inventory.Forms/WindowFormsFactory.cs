using System;
using Inventory.Core;

namespace Inventory.Forms
{
    public class WindowFormsFactory : IWindowFormsFactory
    {

        public IAddNewCategoryView CreateAddNewCategoryView()
        {
            var _frm = new frmAddCategory();

            return _frm;
        }

        public IAddNewEquipmentView CreateAddNewEquipmentView()
        {
            var _frm = new frmAddEquipment();

            return _frm;
        }

        public IAddNewUserView CreateAddNewUserView()
        {
            var _frm = new frmAddUser();

            return _frm;
        }

        public IShowUserListView CreateShowUsersListView()
        {
            var _frm = new frmViewUsers();

            return _frm;
        }

        public IShowEquipmentListView CreateShowEquipmentListView()
        {
            var _frm = new frmViewEquipment();

            return _frm;
        }

        public IAssignEquipmentView CreateAssignEquipmentView()
        {
            var _frm = new frmAssignEquipment();

            return _frm;
        }

        public ITransferEquipmentView CreateTransferEquipmentView()
        {
            var _frm = new frmTransferEquipment();

            return _frm;
        }

        public IDisposeEquipmentView CreateDisposeEquipmentView()
        {
            var _frm = new frmDisposeEquipment();

            return _frm;
        }

        public IDeactivateUserView CreateDeactivateUserView()
        {
            var _frm = new frmDeactivateUser();

            return _frm;
        }
    }
}
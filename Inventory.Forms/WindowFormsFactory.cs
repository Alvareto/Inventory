using System;
using Inventory.Core;

namespace Inventory.Forms
{
    public class WindowFormsFactory : IWindowFormsFactory
    {

        //var newFrm = new frmAddUser(inAccType);

        //return newFrm;

        //var newFrm = new frmViewAccounts();

        //return newFrm;


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
    }
}
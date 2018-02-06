using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmViewUsers : Form, IShowUserListView
    {
        private IMainFormController _controller;
        private readonly BindingSource equipmentBindingSource = new BindingSource();
        private readonly BindingSource inventoryBindingSource = new BindingSource();
        private readonly BindingSource userBindingSource = new BindingSource();

        public frmViewUsers()
        {
            InitializeComponent();
        }

        public void Display(IMainFormController inMainController, List<User> inListUser)
        {
            _controller = inMainController;

            listInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            listUser.AutoGenerateColumns = true;
            listInventory.AutoGenerateColumns = true;
            listEquipment.AutoGenerateColumns = true;

            userBindingSource.DataSource = inListUser;
            inventoryBindingSource.DataSource = new List<Inventory>();
            equipmentBindingSource.DataSource = new List<Equipment>();

            listUser.DataSource = userBindingSource;
            listInventory.DataSource = inventoryBindingSource;
            listEquipment.DataSource = equipmentBindingSource;

            listUser.SelectionChanged += (sender, args) =>
            {
                var u = (User) listUser.CurrentRow?.DataBoundItem;
                if (u != null)
                {
                    inventoryBindingSource.DataSource = u.Equipments;
                    equipmentBindingSource.DataSource = u.Inventory;
                }
            };

            inventoryBindingSource.DataSourceChanged += (sender, args) =>
            {
                inventoryBindingSource.ResetBindings(false);
                //equipmentBindingSource.ResetBindings(false);
                listInventory.DataSource = inventoryBindingSource;
                //listEquipment.DataSource = equipmentBindingSource;
                listInventory.Update();
                //listEquipment.Update();
            };

            listInventory.SelectionChanged += (sender, args) =>
            {
                var inv = (Inventory) listInventory.CurrentRow?.DataBoundItem;
                if (inv != null)
                    equipmentBindingSource.DataSource = new List<Equipment> {inv.Equipments};
            };

            equipmentBindingSource.DataSourceChanged += (sender, args) =>
            {
                equipmentBindingSource.ResetBindings(false);
                listEquipment.DataSource = equipmentBindingSource;
                listEquipment.Update();
            };

            listEquipment.Columns["Users"].Visible = false;
            listEquipment.Columns["Category"].Visible = false;
            listEquipment.Columns["CurrentInventory"].Visible = false;
            listEquipment.Columns["CurrentInventoryUser"].Visible = false;

            listInventory.Columns["Users"].Visible = false;
            listInventory.Columns["Equipments"].Visible = false;

            listUser.Columns["Equipments"].Visible = false;
            listUser.Columns["FirstName"].Visible = false;
            listUser.Columns["LastName"].Visible = false;
            listUser.Columns["Inventory"].Visible = false;

            Show();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _controller.AddUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            _controller.DeactivateUser();
        }

        private void btnAssignEquipment_Click(object sender, EventArgs e)
        {
            _controller.AssignEquipment();
        }

        private void btnTransferEquipment_Click(object sender, EventArgs e)
        {
            _controller.TransferEquipment();
        }
    }
}
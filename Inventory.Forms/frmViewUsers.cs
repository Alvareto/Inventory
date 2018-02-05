using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmViewUsers : Form, IShowUserListView
    {
        private IMainFormController _controller = null;
        BindingSource userBindingSource = new BindingSource();
        BindingSource inventoryBindingSource = new BindingSource();
        BindingSource equipmentBindingSource = new BindingSource();

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
                var u = (User)listUser.CurrentRow.DataBoundItem;
                if (u != null)
                {
                    inventoryBindingSource.DataSource = u.Equipments;
                }
            };

            inventoryBindingSource.DataSourceChanged += (sender, args) =>
            {
                inventoryBindingSource.ResetBindings(false);
                listInventory.DataSource = inventoryBindingSource;
                listInventory.Update();
            };

            listInventory.SelectionChanged += (sender, args) =>
            {
                var inv = (Inventory)listInventory.CurrentRow.DataBoundItem;
                if (inv != null)
                {
                    equipmentBindingSource.DataSource = new List<Equipment> { inv.Equipments };
                }
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

            this.Show();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            _controller.AddUser();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            _controller.DeactivateUser();
        }
    }
}

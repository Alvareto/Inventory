using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Core;
using Inventory.Model;

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Core;
using Inventory.Model;

namespace Inventory.Forms
{
    public partial class frmViewEquipment : Form, IShowEquipmentListView
    {
        private IMainFormController _controller = null;
        BindingSource equipmentBindingSource = new BindingSource();
        BindingSource inventoryBindingSource = new BindingSource();
        BindingSource userBindingSource = new BindingSource();

        public frmViewEquipment()
        {
            InitializeComponent();
        }

        private void frmViewEquipment_Load(object sender, EventArgs e)
        {

        }

        public void Display(IMainFormController inMainController, List<Equipment> inListEquipment)
        {
            _controller = inMainController;


            listInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listEquipment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            equipmentBindingSource.DataSource = inListEquipment;
            listEquipment.DataSource = equipmentBindingSource;

            inventoryBindingSource.DataSource = new List<Inventory>();
            inventoryBindingSource.DataSourceChanged += (sender, args) =>
            {
                inventoryBindingSource.ResetBindings(false);
                listInventory.DataSource = inventoryBindingSource;
                listInventory.Update();
            };
            listInventory.DataSource = inventoryBindingSource;

            userBindingSource.DataSource = new List<User>();
            userBindingSource.DataSourceChanged += (sender, args) =>
            {
                userBindingSource.ResetBindings(false);
                listUser.DataSource = userBindingSource;
                listUser.Update();
            };
            listUser.DataSource = userBindingSource;
            listInventory.SelectionChanged += (sender, args) =>
            {
                var inv = (Inventory)listInventory.CurrentRow.DataBoundItem;
                if (inv != null)
                {
                    userBindingSource.DataSource = new List<User> { inv.Users };
                }
            };

            listEquipment.AutoGenerateColumns = true;
            listInventory.AutoGenerateColumns = true;
            listUser.AutoGenerateColumns = true;

            listEquipment.Columns["Users"].Visible = false;
            listEquipment.Columns["Category"].Visible = false;
            listEquipment.Columns["CurrentInventory"].Visible = false;
            listEquipment.Columns["CurrentInventoryUser"].Visible = false;

            listInventory.Columns["Users"].Visible = false;
            listInventory.Columns["Equipments"].Visible = false;

            listUser.Columns["Equipments"].Visible = false;


            this.Show();
        }

        private void listEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var eq = (Equipment)listEquipment.CurrentRow?.DataBoundItem;
            if (eq != null)
            {
                inventoryBindingSource.DataSource = eq.Users;
            }
            //listInventory.DataSource = inventoryBindingSource;
        }

        private void listEquipment_SelectionChanged(object sender, EventArgs e)
        {
            var eq = (Equipment)listEquipment.CurrentRow.DataBoundItem;
            if (eq != null)
            {
                inventoryBindingSource.DataSource = eq.Users;
            }
        }
        private void btnAddNewEquipment_Click(object sender, EventArgs e)
        {
            _controller.AddEquipment();
        }

        private void btnAssignEquipment_Click(object sender, EventArgs e)
        {
            _controller.AssignEquipment();
        }

        private void btnTransferEquipment_Click(object sender, EventArgs e)
        {
            _controller.TransferEquipment();
        }

        private void btnDisposeEquipment_Click(object sender, EventArgs e)
        {
            _controller.DisposeEquipment();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

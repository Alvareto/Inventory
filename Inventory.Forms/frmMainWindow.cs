using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Controllers;

namespace Inventory.Forms
{
    public partial class frmMainWindow : Form
    {
        private readonly MainFormController _controller;

        public frmMainWindow(MainFormController inController)
        {
            _controller = inController;

            InitializeComponent();
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowUsers();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddUser();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowInventory();
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddEquipment();
        }

        private void transferEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.TransferEquipment();
        }

        private void disposeEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DisposeEquipment();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AddCategory();
        }
        // User -> inventory
        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowUserInventory();
        }

        // Equipment -> users 
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.ShowEquipmentUsers();
        }

        private void deactivateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.DeactivateUser();
        }

        private void assignEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _controller.AssignEquipment();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmAddEquipment : Form, IAddNewEquipmentView
    {
        private readonly BindingList<Category> categoryList = new BindingList<Category>();

        public frmAddEquipment()
        {
            InitializeComponent();

            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
            cmbCategory.DataSource = categoryList;
        }

        public bool Display(List<Category> categories)
        {
            categories.ForEach(c => categoryList.Add(c));

            return ShowDialog() == DialogResult.OK;
        }

        public string EquipmentName => txtName.Text;
        public Category EquipmentCategory => cmbCategory.SelectedItem as Category;
        public DateTime DateAcquired => dateAcquired.Value;

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = -1;
        }

        public bool Display()
        {
            return ShowDialog() == DialogResult.OK;
        }
    }
}
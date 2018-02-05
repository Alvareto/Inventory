using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmAddEquipment : Form, IAddNewEquipmentView
    {
        public frmAddEquipment()
        {
            InitializeComponent();

            cmbCategory.ValueMember = "Id";
            cmbCategory.DisplayMember = "Name";
            cmbCategory.DataSource = categoryList;
        }

        private void frmAddEquipment_Load(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = -1;
        }

        private readonly BindingList<Category> categoryList = new BindingList<Category>();

        public bool Display(List<Category> categories)
        {
            categories.ForEach(c => categoryList.Add(c));

            return this.ShowDialog() == DialogResult.OK;
        }

        public bool Display()
        {
            return this.ShowDialog() == DialogResult.OK;
        }

        public string EquipmentName => txtName.Text;
        public Category EquipmentCategory => cmbCategory.SelectedItem as Category;
        public DateTime DateAcquired => dateAcquired.Value;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmAddCategory : Form, IAddNewCategoryView
    {
        private readonly BindingList<Category> parentList = new BindingList<Category>();

        public frmAddCategory()
        {
            InitializeComponent();

            cmbCategoryParent.ValueMember = nameof(Category.Id); // "Id";
            cmbCategoryParent.DisplayMember = nameof(Category.Name); // "Name";
            cmbCategoryParent.DataSource = parentList;
        }

        public bool Display(List<Category> categories)
        {
            categories.ForEach(c => parentList.Add(c));

            return ShowDialog() == DialogResult.OK;
        }

        public string CategoryName => txtCategoryName.Text;
        public Category ParentCategory => cmbCategoryParent.SelectedItem as Category;

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            cmbCategoryParent.SelectedIndex = -1;
        }
    }
}
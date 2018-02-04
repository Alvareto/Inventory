using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Controllers;
using Inventory.Core;
using Inventory.Model;

namespace Inventory.Forms
{
    public partial class frmAddCategory : Form, IAddNewCategoryView
    {
        public frmAddCategory()
        {
            InitializeComponent();

            cmbCategoryParent.ValueMember = nameof(Category.Id); // "Id";
            cmbCategoryParent.DisplayMember = nameof(Category.Name); // "Name";
            cmbCategoryParent.DataSource = parentList;
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            cmbCategoryParent.SelectedIndex = -1;
        }

        private readonly BindingList<Category> parentList = new BindingList<Category>();

        public bool Display(List<Category> categories)
        {
            categories.ForEach(c => parentList.Add(c));

            return this.ShowDialog() == DialogResult.OK;
        }

        public string CategoryName => txtCategoryName.Text;
        public Category ParentCategory => cmbCategoryParent.SelectedItem as Category;

    }
}

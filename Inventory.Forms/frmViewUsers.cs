using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public frmViewUsers()
        {
            InitializeComponent();
        }

        public void Display(IMainFormController inMainController, List<User> inListUser)
        {
            _controller = inMainController;

            userBindingSource.DataSource = inListUser;

            listUser.DataSource = userBindingSource;
            listUser.AutoGenerateColumns = true;

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
    }
}

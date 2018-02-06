using System;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmAddUser : Form, IAddNewUserView
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        public bool Display()
        {
            return ShowDialog() == DialogResult.OK;
        }

        public string FirstName => txtFirstName.Text;
        public string LastName => txtLastName.Text;
        public DateTime DateHired => dateHired.Value;

        private void frmAddUser_Load(object sender, EventArgs e)
        {
        }
    }
}
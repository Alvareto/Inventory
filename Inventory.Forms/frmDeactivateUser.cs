using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmDeactivateUser : Form, IDeactivateUserView
    {
        private readonly BindingList<User> userList = new BindingList<User>();

        public frmDeactivateUser()
        {
            InitializeComponent();

            cmbUsers.ValueMember = "Id";
            cmbUsers.DisplayMember = "LastName";
            cmbUsers.DataSource = userList;
        }

        public bool Display(List<User> users)
        {
            users.ForEach(c => userList.Add(c));

            return ShowDialog() == DialogResult.OK;
        }

        public User SelectedUser => cmbUsers.SelectedItem as User;
        public DateTime DateFired => dateFired.Value;

        private void frmDeactivateUser_Load(object sender, EventArgs e)
        {
            cmbUsers.SelectedIndex = -1;
        }
    }
}
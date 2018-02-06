using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmAssignEquipment : Form, IAssignEquipmentView
    {
        private readonly BindingList<Equipment> equipmentList = new BindingList<Equipment>();
        private readonly BindingList<User> userList = new BindingList<User>();

        public frmAssignEquipment()
        {
            InitializeComponent();

            cmbUsers.ValueMember = "Id";
            cmbUsers.DisplayMember = "Name";
            cmbUsers.DataSource = userList;

            cmbEquipment.ValueMember = "Id";
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.DataSource = equipmentList;
        }

        public bool Display(List<Equipment> assets, List<User> users)
        {
            users.ForEach(c => userList.Add(c));
            assets.ForEach(c => equipmentList.Add(c));

            return ShowDialog() == DialogResult.OK;
        }

        public Equipment SelectedEquipment => cmbEquipment.SelectedItem as Equipment;
        public User SelectedUser => cmbUsers.SelectedItem as User;
        public DateTime DateFrom => dateAssign.Value;

        private void frmAssignEquipment_Load(object sender, EventArgs e)
        {
            cmbEquipment.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
        }
    }
}
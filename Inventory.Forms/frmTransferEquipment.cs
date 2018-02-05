using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmTransferEquipment : Form, ITransferEquipmentView
    {
        public frmTransferEquipment()
        {
            InitializeComponent();

            cmbUsers.ValueMember = "Id";
            cmbUsers.DisplayMember = "Name";
            cmbUsers.DataSource = userList;

            cmbEquipment.ValueMember = "Id";
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.DataSource = equipmentList;
        }

        private void frmTransferEquipment_Load(object sender, EventArgs e)
        {
            cmbEquipment.SelectedIndex = -1;
            cmbUsers.SelectedIndex = -1;
        }

        private readonly BindingList<Equipment> equipmentList = new BindingList<Equipment>();
        private readonly BindingList<User> userList = new BindingList<User>();

        public bool Display(List<Equipment> assets, List<User> users)
        {
            users.ForEach(c => userList.Add(c));
            assets.ForEach(c => equipmentList.Add(c));

            return this.ShowDialog() == DialogResult.OK;
        }

        public Equipment SelectedTransferEquipment => cmbEquipment.SelectedItem as Equipment;
        public User UserFrom => SelectedTransferEquipment?.CurrentInventoryUser;
        public User SelectedUserTo => cmbUsers.SelectedItem as User;
        public DateTime Date_ExTo_NewFrom => dateTransfer.Value;

        private void cmbEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFromUser.ResetText();
            this.txtFromUser.Text = UserFrom?.Name;
        }
    }
}

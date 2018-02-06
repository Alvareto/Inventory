using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmDisposeEquipment : Form, IDisposeEquipmentView
    {
        private readonly BindingList<Equipment> equipmentList = new BindingList<Equipment>();

        public frmDisposeEquipment()
        {
            InitializeComponent();

            cmbEquipment.ValueMember = "Id";
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.DataSource = equipmentList;
        }

        public bool Display(List<Equipment> assets)
        {
            assets.ForEach(c => equipmentList.Add(c));

            return ShowDialog() == DialogResult.OK;
        }

        public Equipment SelectedEquipment => cmbEquipment.SelectedItem as Equipment;
        public DateTime DateDisposed => dateDisposed.Value;

        private void frmDisposeEquipment_Load(object sender, EventArgs e)
        {
            cmbEquipment.SelectedIndex = -1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Inventory.Core;

namespace Inventory.Forms
{
    public partial class frmDisposeEquipment : Form, IDisposeEquipmentView
    {
        public frmDisposeEquipment()
        {
            InitializeComponent();

            cmbEquipment.ValueMember = "Id";
            cmbEquipment.DisplayMember = "Name";
            cmbEquipment.DataSource = equipmentList;
        }

        private void frmDisposeEquipment_Load(object sender, EventArgs e)
        {
            cmbEquipment.SelectedIndex = -1;
        }

        private readonly BindingList<Equipment> equipmentList = new BindingList<Equipment>();

        public bool Display(List<Equipment> assets)
        {
            assets.ForEach(c => equipmentList.Add(c));

            return this.ShowDialog() == DialogResult.OK;
        }

        public Equipment SelectedEquipment => cmbEquipment.SelectedItem as Equipment;
        public DateTime DateDisposed => dateDisposed.Value;
    }
}

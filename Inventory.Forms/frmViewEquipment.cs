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
    public partial class frmViewEquipment : Form, IShowEquipmentListView
    {
        private IMainFormController _controller = null;
        BindingSource equipmentBindingSource = new BindingSource();

        public frmViewEquipment()
        {
            InitializeComponent();
        }

        private void frmViewEquipment_Load(object sender, EventArgs e)
        {

        }

        public void Display(IMainFormController inMainController, List<Equipment> inListEquipment)
        {
            _controller = inMainController;

            equipmentBindingSource.DataSource = inListEquipment;

            listEquipment.DataSource = equipmentBindingSource;
            listEquipment.AutoGenerateColumns = true;

            this.Show();
        }

        private void btnAddNewEquipment_Click(object sender, EventArgs e)
        {
            _controller.AddEquipment();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

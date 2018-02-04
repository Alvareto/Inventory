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

namespace Inventory.Forms
{
    public partial class frmUserInventoryMasterDetail : Form
    {
        private UsersController _masterCtrl;
        private EquipmentsController _detailCtrl;

        public frmUserInventoryMasterDetail(UsersController u, EquipmentsController e)
        {
            this._masterCtrl = u;
            this._detailCtrl = e;
            InitializeComponent();
        }

        //private List<User> user_data = new List<User>();
        BindingSource userBindingSource = new BindingSource();

        private void frmUserInventoryMasterDetail_Load(object sender, EventArgs e)
        {
            //userBindingSource.DataSource = _masterCtrl.Index();
            //userBindingSource.AllowNew = true;
            ////userBindingSource.

            //dataGridView1.DataSource = userBindingSource;
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.AllowUserToAddRows = true;
        }
    }
}

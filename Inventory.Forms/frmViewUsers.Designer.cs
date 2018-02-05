namespace Inventory.Forms
{
    partial class frmViewUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUser = new System.Windows.Forms.DataGridView();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listInventory = new System.Windows.Forms.DataGridView();
            this.listEquipment = new System.Windows.Forms.DataGridView();
            this.btnDeactivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // listUser
            // 
            this.listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUser.Location = new System.Drawing.Point(12, 12);
            this.listUser.Name = "listUser";
            this.listUser.ReadOnly = true;
            this.listUser.Size = new System.Drawing.Size(537, 178);
            this.listUser.TabIndex = 8;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewUser.Location = new System.Drawing.Point(11, 195);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(140, 27);
            this.btnAddNewUser.TabIndex = 7;
            this.btnAddNewUser.Text = "Hire new employee";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(409, 482);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 27);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listInventory
            // 
            this.listInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInventory.Location = new System.Drawing.Point(12, 239);
            this.listInventory.Name = "listInventory";
            this.listInventory.ReadOnly = true;
            this.listInventory.Size = new System.Drawing.Size(537, 140);
            this.listInventory.TabIndex = 9;
            // 
            // listEquipment
            // 
            this.listEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEquipment.Location = new System.Drawing.Point(12, 385);
            this.listEquipment.Name = "listEquipment";
            this.listEquipment.Size = new System.Drawing.Size(537, 92);
            this.listEquipment.TabIndex = 10;
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeactivate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDeactivate.Location = new System.Drawing.Point(155, 195);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(140, 27);
            this.btnDeactivate.TabIndex = 11;
            this.btnDeactivate.Text = "Fire!";
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // frmViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 520);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.listEquipment);
            this.Controls.Add(this.listInventory);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnClose);
            this.Name = "frmViewUsers";
            this.Text = "frmViewUsers";
            this.Load += new System.EventHandler(this.frmViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listUser;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView listInventory;
        private System.Windows.Forms.DataGridView listEquipment;
        private System.Windows.Forms.Button btnDeactivate;
    }
}
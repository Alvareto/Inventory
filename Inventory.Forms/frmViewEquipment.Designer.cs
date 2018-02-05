namespace Inventory.Forms
{
    partial class frmViewEquipment
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewEquipment = new System.Windows.Forms.Button();
            this.listEquipment = new System.Windows.Forms.DataGridView();
            this.listInventory = new System.Windows.Forms.DataGridView();
            this.listUser = new System.Windows.Forms.DataGridView();
            this.btnAssignEquipment = new System.Windows.Forms.Button();
            this.btnTransferEquipment = new System.Windows.Forms.Button();
            this.btnDisposeEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(464, 185);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewEquipment
            // 
            this.btnAddNewEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewEquipment.Location = new System.Drawing.Point(13, 185);
            this.btnAddNewEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewEquipment.Name = "btnAddNewEquipment";
            this.btnAddNewEquipment.Size = new System.Drawing.Size(109, 27);
            this.btnAddNewEquipment.TabIndex = 4;
            this.btnAddNewEquipment.Text = "Add new equipment";
            this.btnAddNewEquipment.UseVisualStyleBackColor = true;
            this.btnAddNewEquipment.Click += new System.EventHandler(this.btnAddNewEquipment_Click);
            // 
            // listEquipment
            // 
            this.listEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEquipment.Location = new System.Drawing.Point(13, 13);
            this.listEquipment.Name = "listEquipment";
            this.listEquipment.ReadOnly = true;
            this.listEquipment.Size = new System.Drawing.Size(560, 167);
            this.listEquipment.TabIndex = 5;
            this.listEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listEquipment_CellContentClick);
            this.listEquipment.SelectionChanged += new System.EventHandler(this.listEquipment_SelectionChanged);
            // 
            // listInventory
            // 
            this.listInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInventory.Location = new System.Drawing.Point(13, 217);
            this.listInventory.Name = "listInventory";
            this.listInventory.ReadOnly = true;
            this.listInventory.Size = new System.Drawing.Size(560, 114);
            this.listInventory.TabIndex = 6;
            // 
            // listUser
            // 
            this.listUser.AllowUserToAddRows = false;
            this.listUser.AllowUserToDeleteRows = false;
            this.listUser.AllowUserToOrderColumns = true;
            this.listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listUser.Location = new System.Drawing.Point(13, 338);
            this.listUser.Name = "listUser";
            this.listUser.ReadOnly = true;
            this.listUser.Size = new System.Drawing.Size(560, 68);
            this.listUser.TabIndex = 7;
            // 
            // btnAssignEquipment
            // 
            this.btnAssignEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAssignEquipment.Location = new System.Drawing.Point(126, 185);
            this.btnAssignEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignEquipment.Name = "btnAssignEquipment";
            this.btnAssignEquipment.Size = new System.Drawing.Size(109, 27);
            this.btnAssignEquipment.TabIndex = 8;
            this.btnAssignEquipment.Text = "Assign equipment";
            this.btnAssignEquipment.UseVisualStyleBackColor = true;
            this.btnAssignEquipment.Click += new System.EventHandler(this.btnAssignEquipment_Click);
            // 
            // btnTransferEquipment
            // 
            this.btnTransferEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransferEquipment.Location = new System.Drawing.Point(239, 185);
            this.btnTransferEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferEquipment.Name = "btnTransferEquipment";
            this.btnTransferEquipment.Size = new System.Drawing.Size(109, 27);
            this.btnTransferEquipment.TabIndex = 9;
            this.btnTransferEquipment.Text = "Transfer equipment";
            this.btnTransferEquipment.UseVisualStyleBackColor = true;
            this.btnTransferEquipment.Click += new System.EventHandler(this.btnTransferEquipment_Click);
            // 
            // btnDisposeEquipment
            // 
            this.btnDisposeEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDisposeEquipment.Location = new System.Drawing.Point(351, 185);
            this.btnDisposeEquipment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisposeEquipment.Name = "btnDisposeEquipment";
            this.btnDisposeEquipment.Size = new System.Drawing.Size(109, 27);
            this.btnDisposeEquipment.TabIndex = 10;
            this.btnDisposeEquipment.Text = "Dispose equipment";
            this.btnDisposeEquipment.UseVisualStyleBackColor = true;
            this.btnDisposeEquipment.Click += new System.EventHandler(this.btnDisposeEquipment_Click);
            // 
            // frmViewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 418);
            this.Controls.Add(this.btnDisposeEquipment);
            this.Controls.Add(this.btnTransferEquipment);
            this.Controls.Add(this.btnAssignEquipment);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.listInventory);
            this.Controls.Add(this.listEquipment);
            this.Controls.Add(this.btnAddNewEquipment);
            this.Controls.Add(this.btnClose);
            this.Name = "frmViewEquipment";
            this.Text = "Inventory Details";
            this.Load += new System.EventHandler(this.frmViewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewEquipment;
        private System.Windows.Forms.DataGridView listEquipment;
        private System.Windows.Forms.DataGridView listInventory;
        private System.Windows.Forms.DataGridView listUser;
        private System.Windows.Forms.Button btnAssignEquipment;
        private System.Windows.Forms.Button btnTransferEquipment;
        private System.Windows.Forms.Button btnDisposeEquipment;
    }
}
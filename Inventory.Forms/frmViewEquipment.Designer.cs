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
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(271, 328);
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
            this.btnAddNewEquipment.Location = new System.Drawing.Point(72, 328);
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
            this.listEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEquipment.Location = new System.Drawing.Point(13, 13);
            this.listEquipment.Name = "listEquipment";
            this.listEquipment.Size = new System.Drawing.Size(402, 298);
            this.listEquipment.TabIndex = 5;
            // 
            // frmViewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 366);
            this.Controls.Add(this.listEquipment);
            this.Controls.Add(this.btnAddNewEquipment);
            this.Controls.Add(this.btnClose);
            this.Name = "frmViewEquipment";
            this.Text = "frmViewEquipment";
            this.Load += new System.EventHandler(this.frmViewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewEquipment;
        private System.Windows.Forms.DataGridView listEquipment;
    }
}
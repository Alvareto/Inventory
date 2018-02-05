namespace Inventory.Forms
{
    partial class frmTransferEquipment
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTransfer = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransferEquipment = new System.Windows.Forms.Button();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Transfered";
            // 
            // dateTransfer
            // 
            this.dateTransfer.Location = new System.Drawing.Point(74, 79);
            this.dateTransfer.Name = "dateTransfer";
            this.dateTransfer.Size = new System.Drawing.Size(198, 20);
            this.dateTransfer.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Equipment";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(155, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTransferEquipment
            // 
            this.btnTransferEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTransferEquipment.Location = new System.Drawing.Point(74, 105);
            this.btnTransferEquipment.Name = "btnTransferEquipment";
            this.btnTransferEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnTransferEquipment.TabIndex = 13;
            this.btnTransferEquipment.Text = "Transfer";
            this.btnTransferEquipment.UseVisualStyleBackColor = true;
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(74, 12);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(198, 21);
            this.cmbEquipment.TabIndex = 12;
            this.cmbEquipment.SelectedIndexChanged += new System.EventHandler(this.cmbEquipment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "To User";
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(74, 52);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(198, 21);
            this.cmbUsers.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "From User";
            // 
            // txtFromUser
            // 
            this.txtFromUser.AutoSize = true;
            this.txtFromUser.Location = new System.Drawing.Point(74, 36);
            this.txtFromUser.Name = "txtFromUser";
            this.txtFromUser.Size = new System.Drawing.Size(0, 13);
            this.txtFromUser.TabIndex = 21;
            // 
            // frmTransferEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.txtFromUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTransferEquipment);
            this.Controls.Add(this.cmbEquipment);
            this.Name = "frmTransferEquipment";
            this.Text = "frmTransferEquipment";
            this.Load += new System.EventHandler(this.frmTransferEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransferEquipment;
        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtFromUser;
    }
}
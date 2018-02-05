namespace Inventory.Forms
{
    partial class frmDisposeEquipment
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
            this.dateDisposed = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDisposeEquipment = new System.Windows.Forms.Button();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Disposed";
            // 
            // dateDisposed
            // 
            this.dateDisposed.Location = new System.Drawing.Point(68, 33);
            this.dateDisposed.Name = "dateDisposed";
            this.dateDisposed.Size = new System.Drawing.Size(177, 20);
            this.dateDisposed.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Equipment";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(149, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDisposeEquipment
            // 
            this.btnDisposeEquipment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDisposeEquipment.Location = new System.Drawing.Point(68, 67);
            this.btnDisposeEquipment.Name = "btnDisposeEquipment";
            this.btnDisposeEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnDisposeEquipment.TabIndex = 7;
            this.btnDisposeEquipment.Text = "Dispose";
            this.btnDisposeEquipment.UseVisualStyleBackColor = true;
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(68, 6);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(177, 21);
            this.cmbEquipment.TabIndex = 6;
            // 
            // frmDisposeEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 98);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateDisposed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDisposeEquipment);
            this.Controls.Add(this.cmbEquipment);
            this.Name = "frmDisposeEquipment";
            this.Text = "frmDisposeEquipment";
            this.Load += new System.EventHandler(this.frmDisposeEquipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateDisposed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDisposeEquipment;
        private System.Windows.Forms.ComboBox cmbEquipment;
    }
}
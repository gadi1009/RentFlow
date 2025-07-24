namespace RealEstateManagementSystem.Forms;

﻿namespace RealEstateManagementSystem
{
    partial class ReserveVacationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridViewVacation = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewVacation
            // 
            this.dataGridViewVacation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Status,
            this.RentalPrice,
            this.Size});
            this.dataGridViewVacation.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVacation.Name = "dataGridViewVacation";
            this.dataGridViewVacation.Size = new System.Drawing.Size(560, 200);
            this.dataGridViewVacation.TabIndex = 0;

            // 
            // Address
            // 
            this.Address.HeaderText = "כתובת";
            this.Address.Name = "Address";
            this.Address.Width = 150;

            // 
            // Status
            // 
            this.Status.HeaderText = "סטטוס";
            this.Status.Name = "Status";
            this.Status.Width = 80;

            // 
            // RentalPrice
            // 
            this.RentalPrice.HeaderText = "מחיר ללילה";
            this.RentalPrice.Name = "RentalPrice";
            this.RentalPrice.Width = 100;

            // 
            // Size
            // 
            this.Size.HeaderText = "גודל (מ\"ר)";
            this.Size.Name = "Size";
            this.Size.Width = 80;

            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(100, 230);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckIn.TabIndex = 1;

            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(100, 260);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckOut.TabIndex = 2;

            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(12, 236);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(78, 13);
            this.lblCheckIn.TabIndex = 3;
            this.lblCheckIn.Text = "תאריך כניסה:";

            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(12, 266);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(82, 13);
            this.lblCheckOut.TabIndex = 4;
            this.lblCheckOut.Text = "תאריך יציאה:";

            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(320, 240);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(100, 30);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "הזמן";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);

            // 
            // ReserveVacationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dataGridViewVacation);
            this.Name = "ReserveVacationForm";
            this.Text = "הזמנת דירות נופש";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVacation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Button btnReserve;
    }
}

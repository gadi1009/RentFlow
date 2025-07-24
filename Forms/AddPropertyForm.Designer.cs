namespace RealEstateManagementSystem.Forms;

﻿namespace RealEstateManagementSystem
{
    partial class AddPropertyForm
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtRentalPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtOwnerID = new System.Windows.Forms.TextBox();
            this.txtOwnerPhone = new System.Windows.Forms.TextBox();
            this.dtpContractEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPropertyType = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.lblOwnerPhone = new System.Windows.Forms.Label();
            this.lblContractEndDate = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblPropertyType = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(150, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 0;

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
            "מושכר",
            "למכירה"});
            this.cmbStatus.Location = new System.Drawing.Point(150, 60);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 1;

            // 
            // txtRentalPrice
            // 
            this.txtRentalPrice.Location = new System.Drawing.Point(150, 90);
            this.txtRentalPrice.Name = "txtRentalPrice";
            this.txtRentalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtRentalPrice.TabIndex = 2;

            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(150, 120);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 3;

            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(150, 150);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerName.TabIndex = 4;

            // 
            // txtOwnerID
            // 
            this.txtOwnerID.Location = new System.Drawing.Point(150, 180);
            this.txtOwnerID.Name = "txtOwnerID";
            this.txtOwnerID.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerID.TabIndex = 5;

            // 
            // txtOwnerPhone
            // 
            this.txtOwnerPhone.Location = new System.Drawing.Point(150, 210);
            this.txtOwnerPhone.Name = "txtOwnerPhone";
            this.txtOwnerPhone.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerPhone.TabIndex = 6;

            // 
            // dtpContractEndDate
            // 
            this.dtpContractEndDate.Location = new System.Drawing.Point(150, 240);
            this.dtpContractEndDate.Name = "dtpContractEndDate";
            this.dtpContractEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpContractEndDate.TabIndex = 7;

            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(150, 270);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtSalePrice.TabIndex = 8;

            // 
            // txtPropertyType
            // 
            this.txtPropertyType.Location = new System.Drawing.Point(150, 300);
            this.txtPropertyType.Name = "txtPropertyType";
            this.txtPropertyType.Size = new System.Drawing.Size(200, 20);
            this.txtPropertyType.TabIndex = 9;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(46, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "כתובת";

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 60);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "סטטוס";

            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Location = new System.Drawing.Point(50, 90);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(67, 13);
            this.lblRentalPrice.TabIndex = 13;
            this.lblRentalPrice.Text = "מחיר שכירות";

            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(50, 120);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 13);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "גודל במ\"ר";

            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(50, 150);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(65, 13);
            this.lblOwnerName.TabIndex = 15;
            this.lblOwnerName.Text = "שם בעלים";

            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Location = new System.Drawing.Point(50, 180);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(75, 13);
            this.lblOwnerID.TabIndex = 16;
            this.lblOwnerID.Text = "תעודת זהות";

            // 
            // lblOwnerPhone
            // 
            this.lblOwnerPhone.AutoSize = true;
            this.lblOwnerPhone.Location = new System.Drawing.Point(50, 210);
            this.lblOwnerPhone.Name = "lblOwnerPhone";
            this.lblOwnerPhone.Size = new System.Drawing.Size(80, 13);
            this.lblOwnerPhone.TabIndex = 17;
            this.lblOwnerPhone.Text = "מספר טלפון";

            // 
            // lblContractEndDate
            // 
            this.lblContractEndDate.AutoSize = true;
            this.lblContractEndDate.Location = new System.Drawing.Point(50, 240);
            this.lblContractEndDate.Name = "lblContractEndDate";
            this.lblContractEndDate.Size = new System.Drawing.Size(93, 13);
            this.lblContractEndDate.TabIndex = 18;
            this.lblContractEndDate.Text = "תאריך סיום חוזה";

            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(50, 270);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(71, 13);
            this.lblSalePrice.TabIndex = 19;
            this.lblSalePrice.Text = "מחיר מכירה";

            // 
            // lblPropertyType
            // 
            this.lblPropertyType.AutoSize = true;
            this.lblPropertyType.Location = new System.Drawing.Point(50, 300);
            this.lblPropertyType.Name = "lblPropertyType";
            this.lblPropertyType.Size = new System.Drawing.Size(67, 13);
            this.lblPropertyType.TabIndex = 20;
            this.lblPropertyType.Text = "סוג הנכס";

            // 
            // AddPropertyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtRentalPrice);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.txtOwnerID);
            this.Controls.Add(this.txtOwnerPhone);
            this.Controls.Add(this.dtpContractEndDate);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtPropertyType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRentalPrice);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.lblOwnerPhone);
            this.Controls.Add(this.lblContractEndDate);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblPropertyType);
            this.Name = "AddPropertyForm";
            this.Text = "הוסף נכס חדש";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtRentalPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtOwnerID;
        private System.Windows.Forms.TextBox txtOwnerPhone;
        private System.Windows.Forms.DateTimePicker dtpContractEndDate;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtPropertyType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Label lblOwnerPhone;
        private System.Windows.Forms.Label lblContractEndDate;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblPropertyType;
    }
}

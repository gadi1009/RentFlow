namespace RealEstateManagementSystem.Forms;

﻿namespace RealEstateManagementSystem
{
    partial class ManagePropertiesForm
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
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn(); // עמודה חדשה למספר הטלפון של הבעלים
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn(); // עמודה חדשה לתעודת הזהות של הבעלים
            this.ContractEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnDeleteProperty = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.Status,
            this.RentalPrice,
            this.Size,
            this.OwnerName,
            this.OwnerPhone, // עמודת מספר הטלפון של הבעלים
            this.OwnerID, // עמודת תעודת הזהות של הבעלים
            this.ContractEndDate,
            this.SalePrice});
            this.dataGridViewProperties.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.Size = new System.Drawing.Size(1200, 400); // עדכון הגודל להכלת העמודות הנוספות
            this.dataGridViewProperties.TabIndex = 0;

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
            this.RentalPrice.HeaderText = "מחיר שכירות";
            this.RentalPrice.Name = "RentalPrice";
            this.RentalPrice.Width = 100;

            // 
            // Size
            // 
            this.Size.HeaderText = "גודל (מ\"ר)";
            this.Size.Name = "Size";
            this.Size.Width = 80;

            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "שם בעלים";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Width = 120;

            // 
            // OwnerPhone
            // 
            this.OwnerPhone.HeaderText = "טלפון בעלים";
            this.OwnerPhone.Name = "OwnerPhone";
            this.OwnerPhone.Width = 120;

            // 
            // OwnerID
            // 
            this.OwnerID.HeaderText = "תעודת זהות בעלים";
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.Width = 120;

            // 
            // ContractEndDate
            // 
            this.ContractEndDate.HeaderText = "תאריך סיום חוזה";
            this.ContractEndDate.Name = "ContractEndDate";
            this.ContractEndDate.Width = 120;

            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "מחיר מכירה";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 100;

            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(12, 430);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(150, 30);
            this.btnAddProperty.TabIndex = 1;
            this.btnAddProperty.Text = "הוסף נכס";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);

            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(170, 430);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteProperty.TabIndex = 2;
            this.btnDeleteProperty.Text = "מחק נכס";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);

            // 
            // ManagePropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 481); // עדכון גודל חלון עבור העמודות הנוספות
            this.Controls.Add(this.btnDeleteProperty);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.dataGridViewProperties);
            this.Name = "ManagePropertiesForm";
            this.Text = "ניהול נכסים";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProperties;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerPhone; // עמודה למספר הטלפון של הבעלים
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID; // עמודה לתעודת הזהות של הבעלים
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnDeleteProperty;
    }
}

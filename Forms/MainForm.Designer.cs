namespace RealEstateManagementSystem.Forms;

﻿namespace RealEstateManagementSystem
{
    partial class MainForm
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
            this.btnManageProperties = new System.Windows.Forms.Button();
            this.btnReserveVacation = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button(); // לחצן המידע

            this.SuspendLayout();

            // 
            // btnManageProperties
            // 
            this.btnManageProperties.Location = new System.Drawing.Point(50, 30);
            this.btnManageProperties.Name = "btnManageProperties";
            this.btnManageProperties.Size = new System.Drawing.Size(200, 50);
            this.btnManageProperties.TabIndex = 0;
            this.btnManageProperties.Text = "ניהול נכסים";
            this.btnManageProperties.UseVisualStyleBackColor = true;
            this.btnManageProperties.Click += new System.EventHandler(this.btnManageProperties_Click);

            // 
            // btnReserveVacation
            // 
            this.btnReserveVacation.Location = new System.Drawing.Point(50, 100);
            this.btnReserveVacation.Name = "btnReserveVacation";
            this.btnReserveVacation.Size = new System.Drawing.Size(200, 50);
            this.btnReserveVacation.TabIndex = 1;
            this.btnReserveVacation.Text = "הזמנת דירות נופש";
            this.btnReserveVacation.UseVisualStyleBackColor = true;
            this.btnReserveVacation.Click += new System.EventHandler(this.btnReserveVacation_Click);

            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(50, 170);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 50);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "מידע על התוכנה";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnReserveVacation);
            this.Controls.Add(this.btnManageProperties);
            this.Name = "MainForm";
            this.Text = "מערכת ניהול נדל\"ן";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnManageProperties;
        private System.Windows.Forms.Button btnReserveVacation;
        private System.Windows.Forms.Button btnInfo; // לחצן המידע
    }
}

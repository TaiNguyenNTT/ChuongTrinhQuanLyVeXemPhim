﻿namespace GUI
{
    partial class frmAdminNewDesign
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnAdmin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCustomerUC = new System.Windows.Forms.Button();
            this.btnStaffUC = new System.Windows.Forms.Button();
            this.btnDataUC = new System.Windows.Forms.Button();
            this.btnRevenueUC = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnAdmin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 631);
            this.panel2.TabIndex = 2;
            // 
            // pnAdmin
            // 
            this.pnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAdmin.Location = new System.Drawing.Point(0, 95);
            this.pnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnAdmin.Name = "pnAdmin";
            this.pnAdmin.Size = new System.Drawing.Size(1374, 536);
            this.pnAdmin.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnCustomerUC);
            this.panel3.Controls.Add(this.btnStaffUC);
            this.panel3.Controls.Add(this.btnDataUC);
            this.panel3.Controls.Add(this.btnRevenueUC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1374, 95);
            this.panel3.TabIndex = 1;
            // 
            // btnCustomerUC
            // 
            this.btnCustomerUC.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnCustomerUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCustomerUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomerUC.Image = global::GUI.Properties.Resources.people_2_512;
            this.btnCustomerUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCustomerUC.Location = new System.Drawing.Point(434, 15);
            this.btnCustomerUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerUC.Name = "btnCustomerUC";
            this.btnCustomerUC.Size = new System.Drawing.Size(116, 64);
            this.btnCustomerUC.TabIndex = 0;
            this.btnCustomerUC.Text = "Khách Hàng";
            this.btnCustomerUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCustomerUC.UseVisualStyleBackColor = false;
            this.btnCustomerUC.Click += new System.EventHandler(this.btnCustomerUC_Click);
            // 
            // btnStaffUC
            // 
            this.btnStaffUC.BackColor = System.Drawing.Color.Red;
            this.btnStaffUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnStaffUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnStaffUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStaffUC.Image = global::GUI.Properties.Resources.employee_office_staff_3d735bc691173bb5_256x256;
            this.btnStaffUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnStaffUC.Location = new System.Drawing.Point(304, 15);
            this.btnStaffUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStaffUC.Name = "btnStaffUC";
            this.btnStaffUC.Size = new System.Drawing.Size(116, 64);
            this.btnStaffUC.TabIndex = 0;
            this.btnStaffUC.Text = "Nhân Viên";
            this.btnStaffUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStaffUC.UseVisualStyleBackColor = false;
            this.btnStaffUC.Click += new System.EventHandler(this.btnStaffUC_Click);
            // 
            // btnDataUC
            // 
            this.btnDataUC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDataUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnDataUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnDataUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDataUC.Image = global::GUI.Properties.Resources.openfolder_4896;
            this.btnDataUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDataUC.Location = new System.Drawing.Point(170, 15);
            this.btnDataUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDataUC.Name = "btnDataUC";
            this.btnDataUC.Size = new System.Drawing.Size(116, 64);
            this.btnDataUC.TabIndex = 0;
            this.btnDataUC.Text = "Dữ Liệu";
            this.btnDataUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDataUC.UseVisualStyleBackColor = false;
            this.btnDataUC.Click += new System.EventHandler(this.btnDataUC_Click);
            // 
            // btnRevenueUC
            // 
            this.btnRevenueUC.BackColor = System.Drawing.Color.DarkViolet;
            this.btnRevenueUC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnRevenueUC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnRevenueUC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnRevenueUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenueUC.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnRevenueUC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRevenueUC.Image = global::GUI.Properties.Resources.pie_chart;
            this.btnRevenueUC.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRevenueUC.Location = new System.Drawing.Point(40, 15);
            this.btnRevenueUC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevenueUC.Name = "btnRevenueUC";
            this.btnRevenueUC.Size = new System.Drawing.Size(116, 64);
            this.btnRevenueUC.TabIndex = 0;
            this.btnRevenueUC.Text = "Doanh Thu";
            this.btnRevenueUC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRevenueUC.UseVisualStyleBackColor = false;
            this.btnRevenueUC.Click += new System.EventHandler(this.btnRevenueUC_Click);
            // 
            // frmAdminNewDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 631);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAdminNewDesign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCustomerUC;
        private System.Windows.Forms.Button btnStaffUC;
        private System.Windows.Forms.Button btnDataUC;
        private System.Windows.Forms.Button btnRevenueUC;
        private System.Windows.Forms.Panel pnAdmin;
    }
}
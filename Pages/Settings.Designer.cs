﻿namespace SPAAT.Pages
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.crebud = new System.Windows.Forms.Label();
            this.RBM = new Guna.UI2.WinForms.Guna2Button();
            this.RTL = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logout.Animated = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.BorderRadius = 10;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(64, 406);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(176, 56);
            this.logout.TabIndex = 34;
            this.logout.Text = "Log out";
            this.logout.UseTransparentBackground = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // crebud
            // 
            this.crebud.AutoSize = true;
            this.crebud.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.crebud.ForeColor = System.Drawing.Color.White;
            this.crebud.Location = new System.Drawing.Point(22, 21);
            this.crebud.Name = "crebud";
            this.crebud.Size = new System.Drawing.Size(135, 48);
            this.crebud.TabIndex = 37;
            this.crebud.Text = "Settings";
            // 
            // RBM
            // 
            this.RBM.Animated = true;
            this.RBM.BackColor = System.Drawing.Color.Transparent;
            this.RBM.BorderRadius = 10;
            this.RBM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RBM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RBM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RBM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RBM.FillColor = System.Drawing.Color.Maroon;
            this.RBM.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.RBM.ForeColor = System.Drawing.Color.White;
            this.RBM.Location = new System.Drawing.Point(64, 119);
            this.RBM.Name = "RBM";
            this.RBM.Size = new System.Drawing.Size(321, 56);
            this.RBM.TabIndex = 38;
            this.RBM.Text = "Reset Budget Management";
            this.RBM.UseTransparentBackground = true;
            this.RBM.Click += new System.EventHandler(this.RBM_Click);
            // 
            // RTL
            // 
            this.RTL.Animated = true;
            this.RTL.BackColor = System.Drawing.Color.Transparent;
            this.RTL.BorderRadius = 10;
            this.RTL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RTL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RTL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RTL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RTL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RTL.FillColor = System.Drawing.Color.Maroon;
            this.RTL.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.RTL.ForeColor = System.Drawing.Color.White;
            this.RTL.Location = new System.Drawing.Point(64, 208);
            this.RTL.Name = "RTL";
            this.RTL.Size = new System.Drawing.Size(321, 56);
            this.RTL.TabIndex = 39;
            this.RTL.Text = "Reset Transaction Logs";
            this.RTL.UseTransparentBackground = true;
            this.RTL.Click += new System.EventHandler(this.RTL_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.RTL);
            this.Controls.Add(this.RBM);
            this.Controls.Add(this.crebud);
            this.Controls.Add(this.logout);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(750, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logout;
        private System.Windows.Forms.Label crebud;
        private Guna.UI2.WinForms.Guna2Button RBM;
        private Guna.UI2.WinForms.Guna2Button RTL;
    }
}

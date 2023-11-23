namespace SPAAT.SubPages
{
    partial class SubBudMan
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
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.createbudget = new Guna.UI2.WinForms.Guna2Button();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.crebud = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.categorytb = new Guna.UI2.WinForms.Guna2TextBox();
            this.alloctb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.budgetstatuslabel = new System.Windows.Forms.Label();
            this.nametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Animated = true;
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderRadius = 10;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.IndianRed;
            this.delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(552, 424);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 56);
            this.delete.TabIndex = 22;
            this.delete.Text = "Back";
            this.delete.UseTransparentBackground = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // createbudget
            // 
            this.createbudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createbudget.Animated = true;
            this.createbudget.BackColor = System.Drawing.Color.Transparent;
            this.createbudget.BorderRadius = 10;
            this.createbudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createbudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createbudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createbudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createbudget.FillColor = System.Drawing.Color.Teal;
            this.createbudget.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.createbudget.ForeColor = System.Drawing.Color.White;
            this.createbudget.Location = new System.Drawing.Point(552, 300);
            this.createbudget.Name = "createbudget";
            this.createbudget.Size = new System.Drawing.Size(176, 56);
            this.createbudget.TabIndex = 20;
            this.createbudget.Text = "Create";
            this.createbudget.UseTransparentBackground = true;
            this.createbudget.Click += new System.EventHandler(this.createbudget_Click);
            // 
            // modify
            // 
            this.modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify.Animated = true;
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.BorderRadius = 10;
            this.modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modify.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(552, 362);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(176, 56);
            this.modify.TabIndex = 21;
            this.modify.Text = "Clear";
            this.modify.UseTransparentBackground = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // crebud
            // 
            this.crebud.AutoSize = true;
            this.crebud.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.crebud.ForeColor = System.Drawing.Color.White;
            this.crebud.Location = new System.Drawing.Point(13, 14);
            this.crebud.Name = "crebud";
            this.crebud.Size = new System.Drawing.Size(222, 48);
            this.crebud.TabIndex = 23;
            this.crebud.Text = "Create Budget";
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.categorylabel.ForeColor = System.Drawing.Color.White;
            this.categorylabel.Location = new System.Drawing.Point(35, 150);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(113, 36);
            this.categorylabel.TabIndex = 24;
            this.categorylabel.Text = "Category";
            // 
            // categorytb
            // 
            this.categorytb.Animated = true;
            this.categorytb.BackColor = System.Drawing.Color.Transparent;
            this.categorytb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.categorytb.BorderRadius = 10;
            this.categorytb.BorderThickness = 2;
            this.categorytb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorytb.DefaultText = "";
            this.categorytb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categorytb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categorytb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorytb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categorytb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorytb.Font = new System.Drawing.Font("Poppins", 10F);
            this.categorytb.ForeColor = System.Drawing.Color.Black;
            this.categorytb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categorytb.Location = new System.Drawing.Point(41, 189);
            this.categorytb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.categorytb.Name = "categorytb";
            this.categorytb.PasswordChar = '\0';
            this.categorytb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.categorytb.PlaceholderText = "Category...";
            this.categorytb.SelectedText = "";
            this.categorytb.Size = new System.Drawing.Size(428, 41);
            this.categorytb.TabIndex = 25;
            // 
            // alloctb
            // 
            this.alloctb.Animated = true;
            this.alloctb.BackColor = System.Drawing.Color.Transparent;
            this.alloctb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alloctb.BorderRadius = 10;
            this.alloctb.BorderThickness = 2;
            this.alloctb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.alloctb.DefaultText = "";
            this.alloctb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.alloctb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.alloctb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alloctb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.alloctb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alloctb.Font = new System.Drawing.Font("Poppins", 10F);
            this.alloctb.ForeColor = System.Drawing.Color.Black;
            this.alloctb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.alloctb.Location = new System.Drawing.Point(41, 274);
            this.alloctb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.alloctb.Name = "alloctb";
            this.alloctb.PasswordChar = '\0';
            this.alloctb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.alloctb.PlaceholderText = "Allocation...";
            this.alloctb.SelectedText = "";
            this.alloctb.Size = new System.Drawing.Size(428, 41);
            this.alloctb.TabIndex = 27;
            this.alloctb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Allocation";
            // 
            // remtb
            // 
            this.remtb.Animated = true;
            this.remtb.BackColor = System.Drawing.Color.Transparent;
            this.remtb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remtb.BorderRadius = 10;
            this.remtb.BorderThickness = 2;
            this.remtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remtb.DefaultText = "";
            this.remtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.remtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.remtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.remtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.remtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remtb.Font = new System.Drawing.Font("Poppins", 10F);
            this.remtb.ForeColor = System.Drawing.Color.Black;
            this.remtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remtb.Location = new System.Drawing.Point(41, 362);
            this.remtb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remtb.Name = "remtb";
            this.remtb.PasswordChar = '\0';
            this.remtb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.remtb.PlaceholderText = "Remaining...";
            this.remtb.SelectedText = "";
            this.remtb.Size = new System.Drawing.Size(428, 41);
            this.remtb.TabIndex = 29;
            this.remtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Remaining Budget";
            // 
            // budgetstatuslabel
            // 
            this.budgetstatuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetstatuslabel.Enabled = false;
            this.budgetstatuslabel.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.budgetstatuslabel.Location = new System.Drawing.Point(36, 435);
            this.budgetstatuslabel.Name = "budgetstatuslabel";
            this.budgetstatuslabel.Size = new System.Drawing.Size(353, 36);
            this.budgetstatuslabel.TabIndex = 30;
            this.budgetstatuslabel.Text = "BSL";
            this.budgetstatuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.budgetstatuslabel.Visible = false;
            this.budgetstatuslabel.Click += new System.EventHandler(this.budgetstatuslabel_Click);
            // 
            // nametb
            // 
            this.nametb.Animated = true;
            this.nametb.BackColor = System.Drawing.Color.Transparent;
            this.nametb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametb.BorderRadius = 10;
            this.nametb.BorderThickness = 2;
            this.nametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametb.DefaultText = "";
            this.nametb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nametb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nametb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nametb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametb.Font = new System.Drawing.Font("Poppins", 10F);
            this.nametb.ForeColor = System.Drawing.Color.Black;
            this.nametb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nametb.Location = new System.Drawing.Point(41, 104);
            this.nametb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nametb.Name = "nametb";
            this.nametb.PasswordChar = '\0';
            this.nametb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nametb.PlaceholderText = "Name...";
            this.nametb.SelectedText = "";
            this.nametb.Size = new System.Drawing.Size(428, 41);
            this.nametb.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name";
            // 
            // SubBudMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.budgetstatuslabel);
            this.Controls.Add(this.remtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alloctb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorytb);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.crebud);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.createbudget);
            this.Name = "SubBudMan";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.SubBudMan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button createbudget;
        private Guna.UI2.WinForms.Guna2Button modify;
        private System.Windows.Forms.Label crebud;
        private System.Windows.Forms.Label categorylabel;
        private Guna.UI2.WinForms.Guna2TextBox categorytb;
        private Guna.UI2.WinForms.Guna2TextBox alloctb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox remtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label budgetstatuslabel;
        private Guna.UI2.WinForms.Guna2TextBox nametb;
        private System.Windows.Forms.Label label3;
    }
}

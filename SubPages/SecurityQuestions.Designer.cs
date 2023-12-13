namespace SPAAT.SubPages
{
    partial class SecurityQuestions
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
            this.crebud = new System.Windows.Forms.Label();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.sq1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sq2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sq3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // crebud
            // 
            this.crebud.AutoSize = true;
            this.crebud.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.crebud.ForeColor = System.Drawing.Color.White;
            this.crebud.Location = new System.Drawing.Point(16, 14);
            this.crebud.Name = "crebud";
            this.crebud.Size = new System.Drawing.Size(402, 48);
            this.crebud.TabIndex = 39;
            this.crebud.Text = "Manage Security Questions";
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Animated = true;
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderRadius = 10;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.IndianRed;
            this.delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(24, 420);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 56);
            this.delete.TabIndex = 40;
            this.delete.Text = "Back";
            this.delete.UseTransparentBackground = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // sq1
            // 
            this.sq1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq1.BackColor = System.Drawing.Color.Transparent;
            this.sq1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq1.BorderRadius = 10;
            this.sq1.BorderThickness = 2;
            this.sq1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sq1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq1.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq1.ItemHeight = 30;
            this.sq1.Items.AddRange(new object[] {
            "-- Select Security Question --",
            "What is the name of your first pet?",
            "In which city were you born?",
            "What is your mother\'s maiden name?",
            "What is the name of your favorite childhood teacher?",
            "What is the model of your first car?",
            "What is the name of your favorite book?",
            "What is the name of your best friend from childhood?",
            "What is the make of your first computer or laptop?",
            "What was the street you lived on in third grade?",
            "In which year did you graduate from high school?",
            "What is your favorite movie?",
            "What is the name of the street you grew up on?",
            "What is your favorite color?",
            "In which country would you like to retire?",
            "What is the name of the company where you had your first job?",
            "What is your favorite sports team?",
            "What is the middle name of your oldest sibling?",
            "What is the name of the elementary school you attended?",
            "What is the last name of your favorite high school teacher?",
            "What is your favorite holiday destination?"});
            this.sq1.Location = new System.Drawing.Point(73, 81);
            this.sq1.Name = "sq1";
            this.sq1.Size = new System.Drawing.Size(634, 36);
            this.sq1.StartIndex = 0;
            this.sq1.TabIndex = 63;
            this.sq1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sq1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 36);
            this.label2.TabIndex = 66;
            this.label2.Text = "2.";
            // 
            // sq2
            // 
            this.sq2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq2.BackColor = System.Drawing.Color.Transparent;
            this.sq2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq2.BorderRadius = 10;
            this.sq2.BorderThickness = 2;
            this.sq2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sq2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq2.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq2.ItemHeight = 30;
            this.sq2.Items.AddRange(new object[] {
            "-- Select Security Question --",
            "What is the name of your first pet?",
            "In which city were you born?",
            "What is your mother\'s maiden name?",
            "What is the name of your favorite childhood teacher?",
            "What is the model of your first car?",
            "What is the name of your favorite book?",
            "What is the name of your best friend from childhood?",
            "What is the make of your first computer or laptop?",
            "What was the street you lived on in third grade?",
            "In which year did you graduate from high school?",
            "What is your favorite movie?",
            "What is the name of the street you grew up on?",
            "What is your favorite color?",
            "In which country would you like to retire?",
            "What is the name of the company where you had your first job?",
            "What is your favorite sports team?",
            "What is the middle name of your oldest sibling?",
            "What is the name of the elementary school you attended?",
            "What is the last name of your favorite high school teacher?",
            "What is your favorite holiday destination?"});
            this.sq2.Location = new System.Drawing.Point(73, 189);
            this.sq2.Name = "sq2";
            this.sq2.Size = new System.Drawing.Size(634, 36);
            this.sq2.StartIndex = 0;
            this.sq2.TabIndex = 65;
            this.sq2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sq2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 36);
            this.label3.TabIndex = 68;
            this.label3.Text = "3.";
            // 
            // sq3
            // 
            this.sq3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq3.BackColor = System.Drawing.Color.Transparent;
            this.sq3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq3.BorderRadius = 10;
            this.sq3.BorderThickness = 2;
            this.sq3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sq3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sq3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq3.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq3.ItemHeight = 30;
            this.sq3.Items.AddRange(new object[] {
            "-- Select Security Question --",
            "What is the name of your first pet?",
            "In which city were you born?",
            "What is your mother\'s maiden name?",
            "What is the name of your favorite childhood teacher?",
            "What is the model of your first car?",
            "What is the name of your favorite book?",
            "What is the name of your best friend from childhood?",
            "What is the make of your first computer or laptop?",
            "What was the street you lived on in third grade?",
            "In which year did you graduate from high school?",
            "What is your favorite movie?",
            "What is the name of the street you grew up on?",
            "What is your favorite color?",
            "In which country would you like to retire?",
            "What is the name of the company where you had your first job?",
            "What is your favorite sports team?",
            "What is the middle name of your oldest sibling?",
            "What is the name of the elementary school you attended?",
            "What is the last name of your favorite high school teacher?",
            "What is your favorite holiday destination?"});
            this.sq3.Location = new System.Drawing.Point(73, 303);
            this.sq3.Name = "sq3";
            this.sq3.Size = new System.Drawing.Size(634, 36);
            this.sq3.StartIndex = 0;
            this.sq3.TabIndex = 67;
            this.sq3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sq3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // nametb
            // 
            this.nametb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.nametb.Location = new System.Drawing.Point(73, 125);
            this.nametb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nametb.Name = "nametb";
            this.nametb.PasswordChar = '\0';
            this.nametb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nametb.PlaceholderText = "Name...";
            this.nametb.SelectedText = "";
            this.nametb.Size = new System.Drawing.Size(634, 41);
            this.nametb.TabIndex = 69;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.BorderThickness = 2;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(73, 233);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.PlaceholderText = "Name...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(634, 41);
            this.guna2TextBox1.TabIndex = 70;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TextBox2.Animated = true;
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.BorderThickness = 2;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Poppins", 10F);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(73, 347);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox2.PlaceholderText = "Name...";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(634, 41);
            this.guna2TextBox2.TabIndex = 71;
            // 
            // SecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sq3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sq2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sq1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.crebud);
            this.Name = "SecurityQuestions";
            this.Size = new System.Drawing.Size(750, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label crebud;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2ComboBox sq1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox sq2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox sq3;
        private Guna.UI2.WinForms.Guna2TextBox nametb;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}

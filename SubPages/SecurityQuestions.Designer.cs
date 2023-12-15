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
            this.sq1a = new Guna.UI2.WinForms.Guna2TextBox();
            this.sq2a = new Guna.UI2.WinForms.Guna2TextBox();
            this.sq3a = new Guna.UI2.WinForms.Guna2TextBox();
            this.set = new Guna.UI2.WinForms.Guna2Button();
            this.view = new Guna.UI2.WinForms.Guna2Button();
            this.securityStatusLabel = new System.Windows.Forms.Label();
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
            this.delete.Location = new System.Drawing.Point(167, 456);
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
            this.sq1.SelectionChangeCommitted += new System.EventHandler(this.sq1_SelectionChangeCommitted);
            this.sq1.TextUpdate += new System.EventHandler(this.sq1_TextUpdate);
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
            this.sq2.SelectionChangeCommitted += new System.EventHandler(this.sq2_SelectionChangeCommitted);
            this.sq2.TextUpdate += new System.EventHandler(this.sq2_TextUpdate);
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
            this.sq3.SelectionChangeCommitted += new System.EventHandler(this.sq3_SelectionChangeCommitted);
            this.sq3.TextUpdate += new System.EventHandler(this.sq3_TextUpdate);
            // 
            // sq1a
            // 
            this.sq1a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq1a.Animated = true;
            this.sq1a.BackColor = System.Drawing.Color.Transparent;
            this.sq1a.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq1a.BorderRadius = 10;
            this.sq1a.BorderThickness = 2;
            this.sq1a.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq1a.DefaultText = "";
            this.sq1a.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sq1a.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sq1a.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq1a.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq1a.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq1a.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq1a.ForeColor = System.Drawing.Color.Black;
            this.sq1a.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq1a.Location = new System.Drawing.Point(73, 125);
            this.sq1a.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sq1a.MaxLength = 50;
            this.sq1a.Name = "sq1a";
            this.sq1a.PasswordChar = '\0';
            this.sq1a.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sq1a.PlaceholderText = "Answer...";
            this.sq1a.SelectedText = "";
            this.sq1a.Size = new System.Drawing.Size(634, 41);
            this.sq1a.TabIndex = 69;
            // 
            // sq2a
            // 
            this.sq2a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq2a.Animated = true;
            this.sq2a.BackColor = System.Drawing.Color.Transparent;
            this.sq2a.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq2a.BorderRadius = 10;
            this.sq2a.BorderThickness = 2;
            this.sq2a.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq2a.DefaultText = "";
            this.sq2a.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sq2a.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sq2a.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq2a.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq2a.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq2a.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq2a.ForeColor = System.Drawing.Color.Black;
            this.sq2a.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq2a.Location = new System.Drawing.Point(73, 233);
            this.sq2a.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sq2a.MaxLength = 50;
            this.sq2a.Name = "sq2a";
            this.sq2a.PasswordChar = '\0';
            this.sq2a.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sq2a.PlaceholderText = "Answer...";
            this.sq2a.SelectedText = "";
            this.sq2a.Size = new System.Drawing.Size(634, 41);
            this.sq2a.TabIndex = 70;
            // 
            // sq3a
            // 
            this.sq3a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sq3a.Animated = true;
            this.sq3a.BackColor = System.Drawing.Color.Transparent;
            this.sq3a.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sq3a.BorderRadius = 10;
            this.sq3a.BorderThickness = 2;
            this.sq3a.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sq3a.DefaultText = "";
            this.sq3a.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sq3a.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sq3a.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq3a.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sq3a.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq3a.Font = new System.Drawing.Font("Poppins", 10F);
            this.sq3a.ForeColor = System.Drawing.Color.Black;
            this.sq3a.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sq3a.Location = new System.Drawing.Point(73, 347);
            this.sq3a.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sq3a.MaxLength = 50;
            this.sq3a.Name = "sq3a";
            this.sq3a.PasswordChar = '\0';
            this.sq3a.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sq3a.PlaceholderText = "Answer...";
            this.sq3a.SelectedText = "";
            this.sq3a.Size = new System.Drawing.Size(634, 41);
            this.sq3a.TabIndex = 71;
            // 
            // set
            // 
            this.set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.set.Animated = true;
            this.set.BackColor = System.Drawing.Color.Transparent;
            this.set.BorderRadius = 10;
            this.set.Cursor = System.Windows.Forms.Cursors.Hand;
            this.set.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.set.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.set.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.set.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.set.FillColor = System.Drawing.Color.Teal;
            this.set.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.set.ForeColor = System.Drawing.Color.White;
            this.set.Location = new System.Drawing.Point(531, 456);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(176, 56);
            this.set.TabIndex = 72;
            this.set.Text = "Set";
            this.set.UseTransparentBackground = true;
            this.set.Click += new System.EventHandler(this.set_Click);
            // 
            // view
            // 
            this.view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.view.Animated = true;
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.BorderRadius = 10;
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.view.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(349, 456);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(176, 56);
            this.view.TabIndex = 73;
            this.view.Text = "View";
            this.view.UseTransparentBackground = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // securityStatusLabel
            // 
            this.securityStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.securityStatusLabel.Enabled = false;
            this.securityStatusLabel.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.securityStatusLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.securityStatusLabel.Location = new System.Drawing.Point(162, 417);
            this.securityStatusLabel.Name = "securityStatusLabel";
            this.securityStatusLabel.Size = new System.Drawing.Size(545, 36);
            this.securityStatusLabel.TabIndex = 74;
            this.securityStatusLabel.Text = "BSL";
            this.securityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.securityStatusLabel.Visible = false;
            // 
            // SecurityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.securityStatusLabel);
            this.Controls.Add(this.view);
            this.Controls.Add(this.set);
            this.Controls.Add(this.sq3a);
            this.Controls.Add(this.sq2a);
            this.Controls.Add(this.sq1a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sq3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sq2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sq1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.crebud);
            this.DoubleBuffered = true;
            this.Name = "SecurityQuestions";
            this.Size = new System.Drawing.Size(750, 536);
            this.Enter += new System.EventHandler(this.SecurityQuestions_Enter);
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
        private Guna.UI2.WinForms.Guna2TextBox sq1a;
        private Guna.UI2.WinForms.Guna2TextBox sq2a;
        private Guna.UI2.WinForms.Guna2TextBox sq3a;
        private Guna.UI2.WinForms.Guna2Button set;
        private Guna.UI2.WinForms.Guna2Button view;
        private System.Windows.Forms.Label securityStatusLabel;
    }
}

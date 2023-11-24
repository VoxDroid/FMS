namespace SPAAT
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.appbar = new System.Windows.Forms.Label();
            this.exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.dashboardbutton = new Guna.UI2.WinForms.Guna2Button();
            this.budgetmanagement = new Guna.UI2.WinForms.Guna2Button();
            this.logs = new Guna.UI2.WinForms.Guna2Button();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.dashboardpage = new System.Windows.Forms.TabPage();
            this.dashboard1 = new SPAAT.Pages.Dashboard();
            this.budman = new System.Windows.Forms.TabPage();
            this.budgetManagement1 = new SPAAT.Pages.BudgetManagement();
            this.subbudman = new System.Windows.Forms.TabPage();
            this.subBudMan1 = new SPAAT.SubPages.SubBudMan();
            this.modbudman = new System.Windows.Forms.TabPage();
            this.modBudMan1 = new SPAAT.SubPages.ModBudMan();
            this.log = new System.Windows.Forms.TabPage();
            this.transactionLogs1 = new SPAAT.Pages.TransactionLogs();
            this.sublog = new System.Windows.Forms.TabPage();
            this.subTranLo1 = new SPAAT.SubPages.SubTranLo();
            this.modlog = new System.Windows.Forms.TabPage();
            this.modTranLo1 = new SPAAT.SubPages.ModTranLo();
            this.setting = new System.Windows.Forms.TabPage();
            this.settings1 = new SPAAT.Pages.Settings();
            this.export = new System.Windows.Forms.TabPage();
            this.export1 = new SPAAT.Pages.Export();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.exportf = new Guna.UI2.WinForms.Guna2Button();
            this.adminpage = new Guna.UI2.WinForms.Guna2Button();
            this.pages.SuspendLayout();
            this.dashboardpage.SuspendLayout();
            this.budman.SuspendLayout();
            this.subbudman.SuspendLayout();
            this.modbudman.SuspendLayout();
            this.log.SuspendLayout();
            this.sublog.SuspendLayout();
            this.modlog.SuspendLayout();
            this.setting.SuspendLayout();
            this.export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 300;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // appbar
            // 
            this.appbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appbar.BackColor = System.Drawing.Color.Gray;
            this.appbar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbar.ForeColor = System.Drawing.Color.White;
            this.appbar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.appbar.Location = new System.Drawing.Point(-1, -1);
            this.appbar.Name = "appbar";
            this.appbar.Padding = new System.Windows.Forms.Padding(15, 20, 0, 0);
            this.appbar.Size = new System.Drawing.Size(1002, 66);
            this.appbar.TabIndex = 0;
            this.appbar.Text = "SOCCS Financial Management System";
            this.appbar.Click += new System.EventHandler(this.appbar_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Animated = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BorderColor = System.Drawing.Color.Transparent;
            this.exit.BorderRadius = 10;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.IconColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(943, 12);
            this.exit.Name = "exit";
            this.exit.PressedColor = System.Drawing.Color.BurlyWood;
            this.exit.Size = new System.Drawing.Size(45, 29);
            this.exit.TabIndex = 1;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(892, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 2;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuGroupBox1.Location = new System.Drawing.Point(-3, 68);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(217, 524);
            this.bunifuGroupBox1.TabIndex = 4;
            // 
            // dashboardbutton
            // 
            this.dashboardbutton.Animated = true;
            this.dashboardbutton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashboardbutton.Checked = true;
            this.dashboardbutton.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.dashboardbutton.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dashboardbutton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.dashboardbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboardbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboardbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboardbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboardbutton.FillColor = System.Drawing.Color.Transparent;
            this.dashboardbutton.Font = new System.Drawing.Font("Poppins", 10F);
            this.dashboardbutton.ForeColor = System.Drawing.Color.White;
            this.dashboardbutton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardbutton.Image")));
            this.dashboardbutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardbutton.ImageOffset = new System.Drawing.Point(5, 0);
            this.dashboardbutton.Location = new System.Drawing.Point(-3, 68);
            this.dashboardbutton.Name = "dashboardbutton";
            this.dashboardbutton.Size = new System.Drawing.Size(217, 45);
            this.dashboardbutton.TabIndex = 5;
            this.dashboardbutton.Text = "Dashboard";
            this.dashboardbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardbutton.TextOffset = new System.Drawing.Point(5, 0);
            this.dashboardbutton.UseTransparentBackground = true;
            this.dashboardbutton.Click += new System.EventHandler(this.dashboardbutton_Click);
            // 
            // budgetmanagement
            // 
            this.budgetmanagement.Animated = true;
            this.budgetmanagement.BackColor = System.Drawing.Color.Transparent;
            this.budgetmanagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.budgetmanagement.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.budgetmanagement.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.budgetmanagement.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.budgetmanagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.budgetmanagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.budgetmanagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.budgetmanagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.budgetmanagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.budgetmanagement.FillColor = System.Drawing.Color.Transparent;
            this.budgetmanagement.Font = new System.Drawing.Font("Poppins", 10F);
            this.budgetmanagement.ForeColor = System.Drawing.Color.White;
            this.budgetmanagement.Image = ((System.Drawing.Image)(resources.GetObject("budgetmanagement.Image")));
            this.budgetmanagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.budgetmanagement.ImageOffset = new System.Drawing.Point(5, 0);
            this.budgetmanagement.Location = new System.Drawing.Point(-3, 119);
            this.budgetmanagement.Name = "budgetmanagement";
            this.budgetmanagement.Size = new System.Drawing.Size(217, 45);
            this.budgetmanagement.TabIndex = 6;
            this.budgetmanagement.Text = "Budget Management";
            this.budgetmanagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.budgetmanagement.TextOffset = new System.Drawing.Point(5, 0);
            this.budgetmanagement.UseTransparentBackground = true;
            this.budgetmanagement.Click += new System.EventHandler(this.budgetmanagement_Click);
            // 
            // logs
            // 
            this.logs.Animated = true;
            this.logs.BackColor = System.Drawing.Color.Transparent;
            this.logs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logs.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.logs.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logs.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.logs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logs.FillColor = System.Drawing.Color.Transparent;
            this.logs.Font = new System.Drawing.Font("Poppins", 10F);
            this.logs.ForeColor = System.Drawing.Color.White;
            this.logs.Image = ((System.Drawing.Image)(resources.GetObject("logs.Image")));
            this.logs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logs.ImageOffset = new System.Drawing.Point(5, 0);
            this.logs.Location = new System.Drawing.Point(-3, 170);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(217, 45);
            this.logs.TabIndex = 7;
            this.logs.Text = "Transaction Logs";
            this.logs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logs.TextOffset = new System.Drawing.Point(5, 0);
            this.logs.UseTransparentBackground = true;
            this.logs.Click += new System.EventHandler(this.logs_Click);
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Settings.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.Settings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Settings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Poppins", 10F);
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.ImageOffset = new System.Drawing.Point(5, 0);
            this.Settings.Location = new System.Drawing.Point(-3, 272);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(217, 45);
            this.Settings.TabIndex = 8;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.TextOffset = new System.Drawing.Point(5, 0);
            this.Settings.UseTransparentBackground = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(210, 68);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 521);
            this.bunifuSeparator1.TabIndex = 10;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pages.Controls.Add(this.dashboardpage);
            this.pages.Controls.Add(this.budman);
            this.pages.Controls.Add(this.subbudman);
            this.pages.Controls.Add(this.modbudman);
            this.pages.Controls.Add(this.log);
            this.pages.Controls.Add(this.sublog);
            this.pages.Controls.Add(this.modlog);
            this.pages.Controls.Add(this.setting);
            this.pages.Controls.Add(this.export);
            this.pages.Location = new System.Drawing.Point(220, 68);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.dashboardpage;
            this.pages.PageIndex = 0;
            this.pages.PageName = "dashboardpage";
            this.pages.PageTitle = "Dashboard";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(768, 521);
            this.pages.TabIndex = 11;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // dashboardpage
            // 
            this.dashboardpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.dashboardpage.Controls.Add(this.dashboard1);
            this.dashboardpage.Location = new System.Drawing.Point(4, 4);
            this.dashboardpage.Name = "dashboardpage";
            this.dashboardpage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardpage.Size = new System.Drawing.Size(760, 495);
            this.dashboardpage.TabIndex = 0;
            this.dashboardpage.Text = "Dashboard";
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.dashboard1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(3, 3);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(754, 489);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // budman
            // 
            this.budman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budman.Controls.Add(this.budgetManagement1);
            this.budman.Location = new System.Drawing.Point(4, 4);
            this.budman.Name = "budman";
            this.budman.Padding = new System.Windows.Forms.Padding(3);
            this.budman.Size = new System.Drawing.Size(760, 495);
            this.budman.TabIndex = 1;
            this.budman.Text = "Budget Management";
            // 
            // budgetManagement1
            // 
            this.budgetManagement1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budgetManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.budgetManagement1.Location = new System.Drawing.Point(3, 3);
            this.budgetManagement1.Name = "budgetManagement1";
            this.budgetManagement1.Size = new System.Drawing.Size(754, 489);
            this.budgetManagement1.TabIndex = 0;
            // 
            // subbudman
            // 
            this.subbudman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.subbudman.Controls.Add(this.subBudMan1);
            this.subbudman.Location = new System.Drawing.Point(4, 4);
            this.subbudman.Name = "subbudman";
            this.subbudman.Size = new System.Drawing.Size(760, 495);
            this.subbudman.TabIndex = 5;
            this.subbudman.Text = "Budget Management Form";
            // 
            // subBudMan1
            // 
            this.subBudMan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.subBudMan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subBudMan1.Location = new System.Drawing.Point(0, 0);
            this.subBudMan1.Name = "subBudMan1";
            this.subBudMan1.Size = new System.Drawing.Size(760, 495);
            this.subBudMan1.TabIndex = 0;
            // 
            // modbudman
            // 
            this.modbudman.Controls.Add(this.modBudMan1);
            this.modbudman.Location = new System.Drawing.Point(4, 4);
            this.modbudman.Name = "modbudman";
            this.modbudman.Size = new System.Drawing.Size(760, 495);
            this.modbudman.TabIndex = 7;
            this.modbudman.Text = "Edit BMF";
            this.modbudman.UseVisualStyleBackColor = true;
            // 
            // modBudMan1
            // 
            this.modBudMan1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.modBudMan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modBudMan1.Location = new System.Drawing.Point(0, 0);
            this.modBudMan1.Name = "modBudMan1";
            this.modBudMan1.Size = new System.Drawing.Size(760, 495);
            this.modBudMan1.TabIndex = 0;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.log.Controls.Add(this.transactionLogs1);
            this.log.Location = new System.Drawing.Point(4, 4);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(760, 495);
            this.log.TabIndex = 2;
            this.log.Text = "Logs";
            // 
            // transactionLogs1
            // 
            this.transactionLogs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.transactionLogs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionLogs1.Location = new System.Drawing.Point(0, 0);
            this.transactionLogs1.Name = "transactionLogs1";
            this.transactionLogs1.Size = new System.Drawing.Size(760, 495);
            this.transactionLogs1.TabIndex = 0;
            // 
            // sublog
            // 
            this.sublog.Controls.Add(this.subTranLo1);
            this.sublog.Location = new System.Drawing.Point(4, 4);
            this.sublog.Name = "sublog";
            this.sublog.Size = new System.Drawing.Size(760, 495);
            this.sublog.TabIndex = 6;
            this.sublog.Text = "Logs Form";
            this.sublog.UseVisualStyleBackColor = true;
            // 
            // subTranLo1
            // 
            this.subTranLo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.subTranLo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subTranLo1.Location = new System.Drawing.Point(0, 0);
            this.subTranLo1.Name = "subTranLo1";
            this.subTranLo1.Size = new System.Drawing.Size(760, 495);
            this.subTranLo1.TabIndex = 0;
            // 
            // modlog
            // 
            this.modlog.Controls.Add(this.modTranLo1);
            this.modlog.Location = new System.Drawing.Point(4, 4);
            this.modlog.Name = "modlog";
            this.modlog.Size = new System.Drawing.Size(760, 495);
            this.modlog.TabIndex = 8;
            this.modlog.Text = "Edit LF";
            this.modlog.UseVisualStyleBackColor = true;
            // 
            // modTranLo1
            // 
            this.modTranLo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.modTranLo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modTranLo1.Location = new System.Drawing.Point(0, 0);
            this.modTranLo1.Name = "modTranLo1";
            this.modTranLo1.Size = new System.Drawing.Size(760, 495);
            this.modTranLo1.TabIndex = 0;
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.setting.Controls.Add(this.settings1);
            this.setting.Location = new System.Drawing.Point(4, 4);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(760, 495);
            this.setting.TabIndex = 3;
            this.setting.Text = "Settings";
            // 
            // settings1
            // 
            this.settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settings1.Location = new System.Drawing.Point(0, 0);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(760, 495);
            this.settings1.TabIndex = 0;
            this.settings1.Load += new System.EventHandler(this.settings1_Load);
            // 
            // export
            // 
            this.export.Controls.Add(this.export1);
            this.export.Location = new System.Drawing.Point(4, 4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(760, 495);
            this.export.TabIndex = 9;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            // 
            // export1
            // 
            this.export1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.export1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.export1.Location = new System.Drawing.Point(0, 0);
            this.export1.Name = "export1";
            this.export1.Size = new System.Drawing.Size(760, 495);
            this.export1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 381);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.TabIndex = 12;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 96;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 393);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(192, 192);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // exportf
            // 
            this.exportf.Animated = true;
            this.exportf.BackColor = System.Drawing.Color.Transparent;
            this.exportf.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.exportf.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.exportf.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exportf.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.exportf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exportf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exportf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exportf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exportf.FillColor = System.Drawing.Color.Transparent;
            this.exportf.Font = new System.Drawing.Font("Poppins", 10F);
            this.exportf.ForeColor = System.Drawing.Color.White;
            this.exportf.Image = ((System.Drawing.Image)(resources.GetObject("exportf.Image")));
            this.exportf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exportf.ImageOffset = new System.Drawing.Point(5, 0);
            this.exportf.Location = new System.Drawing.Point(-3, 221);
            this.exportf.Name = "exportf";
            this.exportf.Size = new System.Drawing.Size(217, 45);
            this.exportf.TabIndex = 13;
            this.exportf.Text = "Export";
            this.exportf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exportf.TextOffset = new System.Drawing.Point(5, 0);
            this.exportf.UseTransparentBackground = true;
            this.exportf.Click += new System.EventHandler(this.exportf_Click);
            // 
            // adminpage
            // 
            this.adminpage.Animated = true;
            this.adminpage.BackColor = System.Drawing.Color.Transparent;
            this.adminpage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.adminpage.CheckedState.FillColor = System.Drawing.Color.Gray;
            this.adminpage.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminpage.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.adminpage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminpage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminpage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminpage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminpage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminpage.Enabled = false;
            this.adminpage.FillColor = System.Drawing.Color.Transparent;
            this.adminpage.Font = new System.Drawing.Font("Poppins", 10F);
            this.adminpage.ForeColor = System.Drawing.Color.White;
            this.adminpage.Image = ((System.Drawing.Image)(resources.GetObject("adminpage.Image")));
            this.adminpage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminpage.ImageOffset = new System.Drawing.Point(5, 0);
            this.adminpage.Location = new System.Drawing.Point(-3, 323);
            this.adminpage.Name = "adminpage";
            this.adminpage.Size = new System.Drawing.Size(217, 45);
            this.adminpage.TabIndex = 14;
            this.adminpage.Text = "Admin";
            this.adminpage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adminpage.TextOffset = new System.Drawing.Point(5, 0);
            this.adminpage.UseTransparentBackground = true;
            this.adminpage.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1000, 597);
            this.Controls.Add(this.adminpage);
            this.Controls.Add(this.exportf);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.budgetmanagement);
            this.Controls.Add(this.dashboardbutton);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.appbar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAPISAXIS ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.pages.ResumeLayout(false);
            this.dashboardpage.ResumeLayout(false);
            this.budman.ResumeLayout(false);
            this.subbudman.ResumeLayout(false);
            this.modbudman.ResumeLayout(false);
            this.log.ResumeLayout(false);
            this.sublog.ResumeLayout(false);
            this.modlog.ResumeLayout(false);
            this.setting.ResumeLayout(false);
            this.export.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label appbar;
        private Guna.UI2.WinForms.Guna2ControlBox exit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Guna.UI2.WinForms.Guna2Button dashboardbutton;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button logs;
        private Guna.UI2.WinForms.Guna2Button budgetmanagement;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private System.Windows.Forms.TabPage dashboardpage;
        private System.Windows.Forms.TabPage log;
        private System.Windows.Forms.TabPage setting;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.TabPage sublog;
        private System.Windows.Forms.TabPage budman;
        private System.Windows.Forms.TabPage subbudman;
        private Pages.Dashboard dashboard1;
        private Pages.BudgetManagement budgetManagement1;
        private Pages.TransactionLogs transactionLogs1;
        private Pages.Settings settings1;
        private SubPages.SubBudMan subBudMan1;
        private System.Windows.Forms.TabPage modbudman;
        private SubPages.ModBudMan modBudMan1;
        private SubPages.SubTranLo subTranLo1;
        private System.Windows.Forms.TabPage modlog;
        private SubPages.ModTranLo modTranLo1;
        private Guna.UI2.WinForms.Guna2Button exportf;
        private System.Windows.Forms.TabPage export;
        private Pages.Export export1;
        private Guna.UI2.WinForms.Guna2Button adminpage;
    }
}
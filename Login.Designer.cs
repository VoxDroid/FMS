namespace SPAAT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.HideContinue = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.Loading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.ShowContinue = new Guna.UI2.WinForms.Guna2Shapes();
            this.loginbutton = new Guna.UI2.WinForms.Guna2Button();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Blocker = new Guna.UI2.WinForms.Guna2Shapes();
            this.passwordshow = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.Blocker2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.blockerloader = new Guna.UI2.WinForms.Guna2Shapes();
            this.controlbox = new Guna.UI2.WinForms.Guna2Shapes();
            this.controlboxcheck = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.controlcontainer = new Guna.UI2.WinForms.Guna2Shapes();
            this.exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.info = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 300;
            this.guna2BorderlessForm1.BorderRadius = 50;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockForm = false;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.Interval = 300;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(12, 209);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(435, 134);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Fredoka SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(120, 450);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.White;
            this.guna2Button1.Size = new System.Drawing.Size(216, 46);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Continue";
            this.guna2Button1.Tile = true;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Visible = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // HideContinue
            // 
            this.HideContinue.BackColor = System.Drawing.Color.Transparent;
            this.HideContinue.BorderColor = System.Drawing.Color.Transparent;
            this.HideContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.HideContinue.Location = new System.Drawing.Point(75, 496);
            this.HideContinue.Name = "HideContinue";
            this.HideContinue.PolygonSkip = 1;
            this.HideContinue.Rotate = 0F;
            this.HideContinue.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.HideContinue.Size = new System.Drawing.Size(305, 104);
            this.HideContinue.TabIndex = 2;
            this.HideContinue.Text = "guna2Shapes1";
            this.HideContinue.UseTransparentBackground = true;
            this.HideContinue.Zoom = 80;
            this.HideContinue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hover);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Loading
            // 
            this.Loading.AnimationSpeed = 90;
            this.Loading.AutoStart = true;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.Location = new System.Drawing.Point(181, 502);
            this.Loading.Name = "Loading";
            this.Loading.NumberOfCircles = 10;
            this.Loading.ProgressColor = System.Drawing.Color.White;
            this.Loading.Size = new System.Drawing.Size(90, 90);
            this.Loading.TabIndex = 4;
            this.Loading.UseTransparentBackground = true;
            this.Loading.UseWaitCursor = true;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(188, 591);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(71, 25);
            this.loadingLabel.TabIndex = 5;
            this.loadingLabel.Text = "Loading";
            // 
            // ShowContinue
            // 
            this.ShowContinue.BackColor = System.Drawing.Color.Transparent;
            this.ShowContinue.BorderColor = System.Drawing.Color.Transparent;
            this.ShowContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.ShowContinue.Location = new System.Drawing.Point(75, 438);
            this.ShowContinue.Name = "ShowContinue";
            this.ShowContinue.PolygonSkip = 1;
            this.ShowContinue.Rotate = 0F;
            this.ShowContinue.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.ShowContinue.Size = new System.Drawing.Size(305, 67);
            this.ShowContinue.TabIndex = 6;
            this.ShowContinue.Text = "guna2Shapes1";
            this.ShowContinue.UseTransparentBackground = true;
            this.ShowContinue.Zoom = 80;
            // 
            // loginbutton
            // 
            this.loginbutton.Animated = true;
            this.loginbutton.BackColor = System.Drawing.Color.Transparent;
            this.loginbutton.BorderColor = System.Drawing.Color.Transparent;
            this.loginbutton.BorderRadius = 20;
            this.loginbutton.BorderThickness = 2;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginbutton.Enabled = false;
            this.loginbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbutton.FocusedColor = System.Drawing.Color.Transparent;
            this.loginbutton.Font = new System.Drawing.Font("Fredoka SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.HoverState.BorderColor = System.Drawing.Color.White;
            this.loginbutton.IndicateFocus = true;
            this.loginbutton.Location = new System.Drawing.Point(103, 502);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.PressedColor = System.Drawing.Color.White;
            this.loginbutton.Size = new System.Drawing.Size(260, 58);
            this.loginbutton.TabIndex = 9;
            this.loginbutton.Text = "Login";
            this.loginbutton.Tile = true;
            this.loginbutton.UseTransparentBackground = true;
            this.loginbutton.Visible = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BorderColor = System.Drawing.Color.Transparent;
            this.username.BorderRadius = 2;
            this.username.BorderThickness = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.Enabled = false;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.username.Font = new System.Drawing.Font("Poppins", 12F);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.username.Location = new System.Drawing.Point(48, 330);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.MaxLength = 25;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username.PlaceholderText = "Enter your username";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.username.Size = new System.Drawing.Size(361, 53);
            this.username.TabIndex = 10;
            this.username.Visible = false;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTextBox_KeyDown);
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.BorderColor = System.Drawing.Color.Transparent;
            this.password.BorderRadius = 2;
            this.password.BorderThickness = 2;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.Enabled = false;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.password.Font = new System.Drawing.Font("Poppins", 12F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.password.IconRight = ((System.Drawing.Image)(resources.GetObject("password.IconRight")));
            this.password.Location = new System.Drawing.Point(48, 391);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.MaxLength = 25;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password.PlaceholderText = "Enter your password";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.password.Size = new System.Drawing.Size(361, 53);
            this.password.TabIndex = 11;
            this.password.Visible = false;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // Blocker
            // 
            this.Blocker.BackColor = System.Drawing.Color.Transparent;
            this.Blocker.BorderColor = System.Drawing.Color.Transparent;
            this.Blocker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Blocker.Location = new System.Drawing.Point(-5, 104);
            this.Blocker.Name = "Blocker";
            this.Blocker.PolygonSkip = 1;
            this.Blocker.Rotate = 0F;
            this.Blocker.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.Blocker.Size = new System.Drawing.Size(467, 572);
            this.Blocker.TabIndex = 8;
            this.Blocker.Text = "guna2Shapes1";
            this.Blocker.UseTransparentBackground = true;
            this.Blocker.Zoom = 80;
            // 
            // passwordshow
            // 
            this.passwordshow.BackColor = System.Drawing.Color.Transparent;
            this.passwordshow.Checked = true;
            this.passwordshow.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.passwordshow.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.passwordshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordshow.Image = ((System.Drawing.Image)(resources.GetObject("passwordshow.Image")));
            this.passwordshow.ImageOffset = new System.Drawing.Point(0, 0);
            this.passwordshow.ImageRotate = 0F;
            this.passwordshow.ImageSize = new System.Drawing.Size(30, 30);
            this.passwordshow.Location = new System.Drawing.Point(355, 397);
            this.passwordshow.Name = "passwordshow";
            this.passwordshow.Size = new System.Drawing.Size(48, 41);
            this.passwordshow.TabIndex = 12;
            this.passwordshow.UseTransparentBackground = true;
            this.passwordshow.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // Blocker2
            // 
            this.Blocker2.BackColor = System.Drawing.Color.Transparent;
            this.Blocker2.BorderColor = System.Drawing.Color.Transparent;
            this.Blocker2.Enabled = false;
            this.Blocker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Blocker2.Location = new System.Drawing.Point(-5, 220);
            this.Blocker2.Name = "Blocker2";
            this.Blocker2.PolygonSkip = 1;
            this.Blocker2.Rotate = 0F;
            this.Blocker2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.Blocker2.Size = new System.Drawing.Size(467, 572);
            this.Blocker2.TabIndex = 14;
            this.Blocker2.Text = "guna2Shapes1";
            this.Blocker2.UseTransparentBackground = true;
            this.Blocker2.Visible = false;
            this.Blocker2.Zoom = 80;
            this.Blocker2.Click += new System.EventHandler(this.Blocker2_Click);
            // 
            // blockerloader
            // 
            this.blockerloader.BackColor = System.Drawing.Color.Transparent;
            this.blockerloader.BorderColor = System.Drawing.Color.Transparent;
            this.blockerloader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.blockerloader.Location = new System.Drawing.Point(90, 648);
            this.blockerloader.Name = "blockerloader";
            this.blockerloader.PolygonSkip = 1;
            this.blockerloader.Rotate = 0F;
            this.blockerloader.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.blockerloader.Size = new System.Drawing.Size(275, 200);
            this.blockerloader.TabIndex = 15;
            this.blockerloader.Text = "guna2Shapes1";
            this.blockerloader.UseTransparentBackground = true;
            this.blockerloader.Zoom = 80;
            // 
            // controlbox
            // 
            this.controlbox.BackColor = System.Drawing.Color.Transparent;
            this.controlbox.BorderColor = System.Drawing.Color.Gray;
            this.controlbox.BorderThickness = 4;
            this.controlbox.Enabled = false;
            this.controlbox.FillColor = System.Drawing.Color.Gray;
            this.controlbox.Location = new System.Drawing.Point(-119, 571);
            this.controlbox.Name = "controlbox";
            this.controlbox.PolygonSides = 11;
            this.controlbox.PolygonSkip = 1;
            this.controlbox.Rotate = 10F;
            this.controlbox.RoundedRadius = 30;
            this.controlbox.Size = new System.Drawing.Size(200, 200);
            this.controlbox.TabIndex = 16;
            this.controlbox.Text = "guna2Shapes1";
            this.controlbox.UseTransparentBackground = true;
            this.controlbox.Visible = false;
            this.controlbox.Zoom = 80;
            // 
            // controlboxcheck
            // 
            this.controlboxcheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.controlboxcheck.BackColor = System.Drawing.Color.Transparent;
            this.controlboxcheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.controlboxcheck.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.controlboxcheck.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.controlboxcheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlboxcheck.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.controlboxcheck.Image = ((System.Drawing.Image)(resources.GetObject("controlboxcheck.Image")));
            this.controlboxcheck.ImageOffset = new System.Drawing.Point(0, 0);
            this.controlboxcheck.ImageRotate = 0F;
            this.controlboxcheck.ImageSize = new System.Drawing.Size(30, 30);
            this.controlboxcheck.Location = new System.Drawing.Point(13, 616);
            this.controlboxcheck.Name = "controlboxcheck";
            this.controlboxcheck.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.controlboxcheck.ShadowDecoration.BorderRadius = 10;
            this.controlboxcheck.ShadowDecoration.Enabled = true;
            this.controlboxcheck.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.controlboxcheck.Size = new System.Drawing.Size(20, 20);
            this.controlboxcheck.TabIndex = 17;
            this.controlboxcheck.UseTransparentBackground = true;
            this.controlboxcheck.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged_1);
            // 
            // controlcontainer
            // 
            this.controlcontainer.BackColor = System.Drawing.Color.Transparent;
            this.controlcontainer.BorderColor = System.Drawing.Color.Gray;
            this.controlcontainer.BorderThickness = 4;
            this.controlcontainer.Enabled = false;
            this.controlcontainer.FillColor = System.Drawing.Color.Gray;
            this.controlcontainer.Location = new System.Drawing.Point(231, 609);
            this.controlcontainer.Name = "controlcontainer";
            this.controlcontainer.PolygonSides = 4;
            this.controlcontainer.PolygonSkip = 1;
            this.controlcontainer.Rotate = 0F;
            this.controlcontainer.RoundedRadius = 30;
            this.controlcontainer.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.controlcontainer.Size = new System.Drawing.Size(375, 103);
            this.controlcontainer.TabIndex = 18;
            this.controlcontainer.Text = "guna2Shapes1";
            this.controlcontainer.UseTransparentBackground = true;
            this.controlcontainer.Visible = false;
            this.controlcontainer.Zoom = 100;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit.ImageRotate = 0F;
            this.exit.ImageSize = new System.Drawing.Size(30, 30);
            this.exit.Location = new System.Drawing.Point(421, 616);
            this.exit.Name = "exit";
            this.exit.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 19;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.minimize.ImageRotate = 0F;
            this.minimize.ImageSize = new System.Drawing.Size(30, 30);
            this.minimize.Location = new System.Drawing.Point(343, 616);
            this.minimize.Name = "minimize";
            this.minimize.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.minimize.Size = new System.Drawing.Size(20, 20);
            this.minimize.TabIndex = 20;
            this.minimize.UseTransparentBackground = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.ImageOffset = new System.Drawing.Point(0, 0);
            this.info.ImageRotate = 0F;
            this.info.ImageSize = new System.Drawing.Size(30, 30);
            this.info.Location = new System.Drawing.Point(265, 616);
            this.info.Name = "info";
            this.info.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.info.Size = new System.Drawing.Size(20, 20);
            this.info.TabIndex = 21;
            this.info.UseTransparentBackground = true;
            // 
            // lblError
            // 
            this.lblError.Enabled = false;
            this.lblError.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(103, 470);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(260, 23);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "Stats.";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(459, 648);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.info);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.controlcontainer);
            this.Controls.Add(this.controlboxcheck);
            this.Controls.Add(this.controlbox);
            this.Controls.Add(this.blockerloader);
            this.Controls.Add(this.Blocker2);
            this.Controls.Add(this.passwordshow);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.Blocker);
            this.Controls.Add(this.ShowContinue);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.HideContinue);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Logo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZAPISAXIS";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Hover);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Shapes HideContinue;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator Loading;
        private System.Windows.Forms.Label loadingLabel;
        private Guna.UI2.WinForms.Guna2Shapes ShowContinue;
        private Guna.UI2.WinForms.Guna2Button loginbutton;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2Shapes Blocker;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passwordshow;
        private Guna.UI2.WinForms.Guna2Shapes Blocker2;
        private Guna.UI2.WinForms.Guna2Shapes blockerloader;
        private Guna.UI2.WinForms.Guna2Shapes controlbox;
        private Guna.UI2.WinForms.Guna2ImageCheckBox controlboxcheck;
        private Guna.UI2.WinForms.Guna2Shapes controlcontainer;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2ImageButton info;
        private Guna.UI2.WinForms.Guna2ImageButton minimize;
        private System.Windows.Forms.Label lblError;
    }
}


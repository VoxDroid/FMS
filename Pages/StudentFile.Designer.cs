﻿namespace SPAAT.Pages
{
    partial class StudentFile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentFile));
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.budmangrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.totalentrieslabel = new System.Windows.Forms.Label();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.createbudget = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.debts = new Guna.UI2.WinForms.Guna2Button();
            this.TFC = new System.Windows.Forms.Label();
            this.TFC2 = new System.Windows.Forms.Label();
            this.filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sbo = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.Animated = true;
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.BorderRadius = 10;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(556, 204);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 56);
            this.delete.TabIndex = 28;
            this.delete.Text = "Delete";
            this.delete.UseTransparentBackground = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // budmangrid
            // 
            this.budmangrid.AllowUserToAddRows = false;
            this.budmangrid.AllowUserToDeleteRows = false;
            this.budmangrid.AllowUserToResizeColumns = false;
            this.budmangrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.budmangrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budmangrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.budmangrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.budmangrid.ColumnHeadersHeight = 35;
            this.budmangrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.charge,
            this.amountpaid,
            this.paymentdate,
            this.status,
            this.sn_id,
            this.pm_id});
            this.budmangrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budmangrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.budmangrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.Location = new System.Drawing.Point(18, 15);
            this.budmangrid.MultiSelect = false;
            this.budmangrid.Name = "budmangrid";
            this.budmangrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.budmangrid.RowHeadersVisible = false;
            this.budmangrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.budmangrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.budmangrid.ShowCellErrors = false;
            this.budmangrid.ShowCellToolTips = false;
            this.budmangrid.ShowEditingIcon = false;
            this.budmangrid.ShowRowErrors = false;
            this.budmangrid.Size = new System.Drawing.Size(531, 661);
            this.budmangrid.TabIndex = 25;
            this.budmangrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.budmangrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.budmangrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.budmangrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.budmangrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.budmangrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.budmangrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budmangrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.budmangrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.budmangrid.ThemeStyle.HeaderStyle.Height = 35;
            this.budmangrid.ThemeStyle.ReadOnly = true;
            this.budmangrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.budmangrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.budmangrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budmangrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.budmangrid.ThemeStyle.RowsStyle.Height = 22;
            this.budmangrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.budmangrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.budmangrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.budmangrid_CellContentClick);
            this.budmangrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.budmangrid_CellFormatting);
            this.budmangrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.budmangrid_CellMouseEnter);
            this.budmangrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.budmangrid_CellMouseLeave);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // charge
            // 
            this.charge.HeaderText = "Charge";
            this.charge.Name = "charge";
            this.charge.ReadOnly = true;
            // 
            // amountpaid
            // 
            this.amountpaid.HeaderText = "Amount Paid";
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.ReadOnly = true;
            // 
            // paymentdate
            // 
            this.paymentdate.HeaderText = "Payment Date";
            this.paymentdate.Name = "paymentdate";
            this.paymentdate.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // sn_id
            // 
            this.sn_id.HeaderText = "sn_id";
            this.sn_id.Name = "sn_id";
            this.sn_id.ReadOnly = true;
            this.sn_id.Visible = false;
            // 
            // pm_id
            // 
            this.pm_id.HeaderText = "pm_id";
            this.pm_id.Name = "pm_id";
            this.pm_id.ReadOnly = true;
            this.pm_id.Visible = false;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.budmangrid;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 4;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(539, 15);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 10;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(10, 661);
            this.guna2VScrollBar1.TabIndex = 33;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.Value = 1;
            // 
            // totalentrieslabel
            // 
            this.totalentrieslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalentrieslabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalentrieslabel.ForeColor = System.Drawing.Color.White;
            this.totalentrieslabel.Location = new System.Drawing.Point(576, 432);
            this.totalentrieslabel.Name = "totalentrieslabel";
            this.totalentrieslabel.Size = new System.Drawing.Size(146, 83);
            this.totalentrieslabel.TabIndex = 31;
            this.totalentrieslabel.Text = "Total Entries:";
            this.totalentrieslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalentrieslabel.Click += new System.EventHandler(this.totalentrieslabel_Click);
            // 
            // searchlabel
            // 
            this.searchlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlabel.AutoSize = true;
            this.searchlabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlabel.ForeColor = System.Drawing.Color.White;
            this.searchlabel.Location = new System.Drawing.Point(612, 598);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(76, 28);
            this.searchlabel.TabIndex = 30;
            this.searchlabel.Text = "Search:";
            // 
            // searchtextbox
            // 
            this.searchtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtextbox.Animated = true;
            this.searchtextbox.BackColor = System.Drawing.Color.Transparent;
            this.searchtextbox.BorderColor = System.Drawing.Color.White;
            this.searchtextbox.BorderRadius = 10;
            this.searchtextbox.BorderThickness = 2;
            this.searchtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtextbox.DefaultText = "";
            this.searchtextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchtextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchtextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.searchtextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtextbox.Font = new System.Drawing.Font("Poppins", 12F);
            this.searchtextbox.ForeColor = System.Drawing.Color.White;
            this.searchtextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtextbox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchtextbox.IconRight")));
            this.searchtextbox.IconRightOffset = new System.Drawing.Point(10, 0);
            this.searchtextbox.Location = new System.Drawing.Point(556, 632);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.PasswordChar = '\0';
            this.searchtextbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchtextbox.PlaceholderText = "Search...";
            this.searchtextbox.SelectedText = "";
            this.searchtextbox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.searchtextbox.Size = new System.Drawing.Size(186, 42);
            this.searchtextbox.TabIndex = 29;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // modify
            // 
            this.modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modify.Animated = true;
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.BorderRadius = 10;
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modify.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(556, 142);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(176, 56);
            this.modify.TabIndex = 27;
            this.modify.Text = "Modify";
            this.modify.UseTransparentBackground = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // createbudget
            // 
            this.createbudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createbudget.Animated = true;
            this.createbudget.BackColor = System.Drawing.Color.Transparent;
            this.createbudget.BorderRadius = 10;
            this.createbudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbudget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createbudget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createbudget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createbudget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createbudget.FillColor = System.Drawing.Color.Teal;
            this.createbudget.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.createbudget.ForeColor = System.Drawing.Color.White;
            this.createbudget.Location = new System.Drawing.Point(556, 18);
            this.createbudget.Name = "createbudget";
            this.createbudget.Size = new System.Drawing.Size(176, 56);
            this.createbudget.TabIndex = 26;
            this.createbudget.Text = "Create Entry";
            this.createbudget.UseTransparentBackground = true;
            this.createbudget.Click += new System.EventHandler(this.createbudget_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.AutomaticDelay = 0;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2HtmlToolTip1.Font = new System.Drawing.Font("Poppins", 15F);
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2HtmlToolTip1.UseAnimation = false;
            this.guna2HtmlToolTip1.UseFading = false;
            this.guna2HtmlToolTip1.UseGdiPlusTextRendering = true;
            // 
            // debts
            // 
            this.debts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.debts.Animated = true;
            this.debts.BackColor = System.Drawing.Color.Transparent;
            this.debts.BorderRadius = 10;
            this.debts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.debts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.debts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.debts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.debts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.debts.FillColor = System.Drawing.Color.Teal;
            this.debts.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.debts.ForeColor = System.Drawing.Color.White;
            this.debts.Location = new System.Drawing.Point(555, 80);
            this.debts.Name = "debts";
            this.debts.Size = new System.Drawing.Size(176, 56);
            this.debts.TabIndex = 34;
            this.debts.Text = "View Debts";
            this.debts.UseTransparentBackground = true;
            this.debts.Click += new System.EventHandler(this.debts_Click);
            // 
            // TFC
            // 
            this.TFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TFC.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.TFC.ForeColor = System.Drawing.Color.White;
            this.TFC.Location = new System.Drawing.Point(550, 354);
            this.TFC.Name = "TFC";
            this.TFC.Size = new System.Drawing.Size(192, 70);
            this.TFC.TabIndex = 35;
            this.TFC.Text = "Total Funds Collected:\r\nN/A";
            this.TFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TFC2
            // 
            this.TFC2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TFC2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.TFC2.ForeColor = System.Drawing.Color.White;
            this.TFC2.Location = new System.Drawing.Point(550, 272);
            this.TFC2.Name = "TFC2";
            this.TFC2.Size = new System.Drawing.Size(192, 70);
            this.TFC2.TabIndex = 36;
            this.TFC2.Text = "Total Charge Amount:\r\nN/A";
            this.TFC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filter
            // 
            this.filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter.BackColor = System.Drawing.Color.Transparent;
            this.filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filter.BorderRadius = 10;
            this.filter.BorderThickness = 2;
            this.filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.filter.Font = new System.Drawing.Font("Poppins", 10F);
            this.filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filter.ItemHeight = 30;
            this.filter.Items.AddRange(new object[] {
            "Show All",
            "Partial",
            "Paid"});
            this.filter.Location = new System.Drawing.Point(555, 557);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(143, 36);
            this.filter.StartIndex = 0;
            this.filter.TabIndex = 63;
            this.filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 64;
            this.label1.Text = "Filter by Status:";
            // 
            // sbo
            // 
            this.sbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbo.BackColor = System.Drawing.Color.Transparent;
            this.sbo.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sbo.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbo.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Image = ((System.Drawing.Image)(resources.GetObject("sbo.Image")));
            this.sbo.ImageOffset = new System.Drawing.Point(0, 0);
            this.sbo.ImageRotate = 0F;
            this.sbo.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Location = new System.Drawing.Point(704, 557);
            this.sbo.Name = "sbo";
            this.sbo.Size = new System.Drawing.Size(38, 36);
            this.sbo.TabIndex = 65;
            this.sbo.UseTransparentBackground = true;
            this.sbo.CheckedChanged += new System.EventHandler(this.sbo_CheckedChanged);
            // 
            // StudentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.sbo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.TFC2);
            this.Controls.Add(this.TFC);
            this.Controls.Add(this.debts);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.budmangrid);
            this.Controls.Add(this.totalentrieslabel);
            this.Controls.Add(this.searchlabel);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.createbudget);
            this.DoubleBuffered = true;
            this.Name = "StudentFile";
            this.Size = new System.Drawing.Size(750, 691);
            this.Load += new System.EventHandler(this.StudentFile_Load);
            this.Enter += new System.EventHandler(this.StudentFile_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2DataGridView budmangrid;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.Label totalentrieslabel;
        private System.Windows.Forms.Label searchlabel;
        private Guna.UI2.WinForms.Guna2TextBox searchtextbox;
        private Guna.UI2.WinForms.Guna2Button modify;
        private Guna.UI2.WinForms.Guna2Button createbudget;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Button debts;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_id;
        private System.Windows.Forms.Label TFC;
        private System.Windows.Forms.Label TFC2;
        private Guna.UI2.WinForms.Guna2ComboBox filter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox sbo;
    }
}

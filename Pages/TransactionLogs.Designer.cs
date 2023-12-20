﻿namespace SPAAT.Pages
{
    partial class TransactionLogs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionLogs));
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.budmangrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.totalentrieslabel = new System.Windows.Forms.Label();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.createbudget = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.TFC = new System.Windows.Forms.Label();
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
            this.delete.Location = new System.Drawing.Point(556, 142);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.budmangrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budmangrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.budmangrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.budmangrid.ColumnHeadersHeight = 35;
            this.budmangrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.name,
            this.desc,
            this.cat,
            this.amount});
            this.budmangrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budmangrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.budmangrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.Location = new System.Drawing.Point(18, 15);
            this.budmangrid.MultiSelect = false;
            this.budmangrid.Name = "budmangrid";
            this.budmangrid.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.budmangrid.RowHeadersVisible = false;
            this.budmangrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.budmangrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.budmangrid.ShowCellErrors = false;
            this.budmangrid.ShowCellToolTips = false;
            this.budmangrid.ShowEditingIcon = false;
            this.budmangrid.ShowRowErrors = false;
            this.budmangrid.Size = new System.Drawing.Size(531, 643);
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
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Date Added";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // cat
            // 
            this.cat.HeaderText = "Category";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.budmangrid;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(531, 15);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 643);
            this.guna2VScrollBar1.TabIndex = 33;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.Value = 1;
            // 
            // totalentrieslabel
            // 
            this.totalentrieslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalentrieslabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalentrieslabel.ForeColor = System.Drawing.Color.White;
            this.totalentrieslabel.Location = new System.Drawing.Point(574, 436);
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
            this.searchlabel.Location = new System.Drawing.Point(612, 548);
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
            this.searchtextbox.Location = new System.Drawing.Point(556, 582);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.PasswordChar = '\0';
            this.searchtextbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchtextbox.PlaceholderText = "Search...";
            this.searchtextbox.SelectedText = "";
            this.searchtextbox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.searchtextbox.Size = new System.Drawing.Size(141, 42);
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
            this.modify.Location = new System.Drawing.Point(556, 80);
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
            this.createbudget.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.createbudget.ForeColor = System.Drawing.Color.White;
            this.createbudget.Location = new System.Drawing.Point(556, 18);
            this.createbudget.Name = "createbudget";
            this.createbudget.Size = new System.Drawing.Size(176, 56);
            this.createbudget.TabIndex = 26;
            this.createbudget.Text = "Create Transaction";
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
            // TFC
            // 
            this.TFC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TFC.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.TFC.ForeColor = System.Drawing.Color.White;
            this.TFC.Location = new System.Drawing.Point(550, 343);
            this.TFC.Name = "TFC";
            this.TFC.Size = new System.Drawing.Size(192, 83);
            this.TFC.TabIndex = 36;
            this.TFC.Text = "Total Used Up Amount:";
            this.TFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sbo.Location = new System.Drawing.Point(704, 582);
            this.sbo.Name = "sbo";
            this.sbo.Size = new System.Drawing.Size(38, 42);
            this.sbo.TabIndex = 67;
            this.sbo.UseTransparentBackground = true;
            this.sbo.CheckedChanged += new System.EventHandler(this.sbo_CheckedChanged);
            // 
            // TransactionLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.sbo);
            this.Controls.Add(this.TFC);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.budmangrid);
            this.Controls.Add(this.totalentrieslabel);
            this.Controls.Add(this.searchlabel);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.createbudget);
            this.DoubleBuffered = true;
            this.Name = "TransactionLogs";
            this.Size = new System.Drawing.Size(750, 673);
            this.Enter += new System.EventHandler(this.TransactionLogs_Enter);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.Label TFC;
        private Guna.UI2.WinForms.Guna2ImageCheckBox sbo;
    }
}

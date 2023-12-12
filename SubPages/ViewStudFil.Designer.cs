namespace SPAAT.SubPages
{
    partial class ViewStudFil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudFil));
            this.budmangrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.crebud = new System.Windows.Forms.Label();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TFC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // budmangrid
            // 
            this.budmangrid.AllowUserToAddRows = false;
            this.budmangrid.AllowUserToDeleteRows = false;
            this.budmangrid.AllowUserToResizeColumns = false;
            this.budmangrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.budmangrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.budmangrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.budmangrid.ColumnHeadersHeight = 35;
            this.budmangrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.debtamount,
            this.sn_id});
            this.budmangrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budmangrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.budmangrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.budmangrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.Location = new System.Drawing.Point(0, 0);
            this.budmangrid.MultiSelect = false;
            this.budmangrid.Name = "budmangrid";
            this.budmangrid.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.budmangrid.RowHeadersVisible = false;
            this.budmangrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.budmangrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.budmangrid.ShowCellErrors = false;
            this.budmangrid.ShowCellToolTips = false;
            this.budmangrid.ShowEditingIcon = false;
            this.budmangrid.ShowRowErrors = false;
            this.budmangrid.Size = new System.Drawing.Size(710, 353);
            this.budmangrid.TabIndex = 26;
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
            // debtamount
            // 
            this.debtamount.HeaderText = "Total Unpaid Amount";
            this.debtamount.Name = "debtamount";
            this.debtamount.ReadOnly = true;
            // 
            // sn_id
            // 
            this.sn_id.HeaderText = "sn_id";
            this.sn_id.Name = "sn_id";
            this.sn_id.ReadOnly = true;
            this.sn_id.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.guna2VScrollBar1);
            this.guna2Panel1.Controls.Add(this.budmangrid);
            this.guna2Panel1.Location = new System.Drawing.Point(18, 71);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(710, 353);
            this.guna2Panel1.TabIndex = 27;
            this.guna2Panel1.UseTransparentBackground = true;
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
            this.guna2VScrollBar1.Location = new System.Drawing.Point(692, 0);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 353);
            this.guna2VScrollBar1.TabIndex = 34;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.Value = 1;
            // 
            // modify
            // 
            this.modify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify.Animated = true;
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.BorderRadius = 10;
            this.modify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modify.FillColor = System.Drawing.Color.Teal;
            this.modify.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(379, 430);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(349, 50);
            this.modify.TabIndex = 28;
            this.modify.Text = "Refresh";
            this.modify.UseTransparentBackground = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(18, 430);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(349, 50);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // crebud
            // 
            this.crebud.AutoSize = true;
            this.crebud.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.crebud.ForeColor = System.Drawing.Color.White;
            this.crebud.Location = new System.Drawing.Point(19, 20);
            this.crebud.Name = "crebud";
            this.crebud.Size = new System.Drawing.Size(175, 48);
            this.crebud.TabIndex = 55;
            this.crebud.Text = "View Debts";
            // 
            // searchlabel
            // 
            this.searchlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlabel.AutoSize = true;
            this.searchlabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlabel.ForeColor = System.Drawing.Color.White;
            this.searchlabel.Location = new System.Drawing.Point(490, 28);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(76, 28);
            this.searchlabel.TabIndex = 91;
            this.searchlabel.Text = "Search:";
            this.searchlabel.Click += new System.EventHandler(this.searchlabel_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.searchtextbox.Location = new System.Drawing.Point(569, 20);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.PasswordChar = '\0';
            this.searchtextbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchtextbox.PlaceholderText = "Search...";
            this.searchtextbox.SelectedText = "";
            this.searchtextbox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.searchtextbox.Size = new System.Drawing.Size(159, 42);
            this.searchtextbox.TabIndex = 90;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
            // 
            // TFC
            // 
            this.TFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TFC.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.TFC.ForeColor = System.Drawing.Color.White;
            this.TFC.Location = new System.Drawing.Point(200, 23);
            this.TFC.Name = "TFC";
            this.TFC.Size = new System.Drawing.Size(284, 39);
            this.TFC.TabIndex = 92;
            this.TFC.Text = "Total Uncollected Dues:";
            this.TFC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewStudFil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.TFC);
            this.Controls.Add(this.searchlabel);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.crebud);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ViewStudFil";
            this.Size = new System.Drawing.Size(750, 500);
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView budmangrid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button modify;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn_id;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Label crebud;
        private System.Windows.Forms.Label searchlabel;
        private Guna.UI2.WinForms.Guna2TextBox searchtextbox;
        private System.Windows.Forms.Label TFC;
    }
}

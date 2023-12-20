namespace SPAAT.Pages
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalfundslabel = new System.Windows.Forms.Label();
            this.budgetremainlabel = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.third = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.budmangrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountpaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.totalfundslabel;
            // 
            // totalfundslabel
            // 
            this.totalfundslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalfundslabel.BackColor = System.Drawing.Color.Gray;
            this.totalfundslabel.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.totalfundslabel.ForeColor = System.Drawing.Color.White;
            this.totalfundslabel.Location = new System.Drawing.Point(22, 24);
            this.totalfundslabel.Name = "totalfundslabel";
            this.totalfundslabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.totalfundslabel.Size = new System.Drawing.Size(818, 88);
            this.totalfundslabel.TabIndex = 4;
            this.totalfundslabel.Text = "Total Funds:";
            this.totalfundslabel.Click += new System.EventHandler(this.totalfundslabel_Click);
            // 
            // budgetremainlabel
            // 
            this.budgetremainlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetremainlabel.BackColor = System.Drawing.Color.Gray;
            this.budgetremainlabel.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.budgetremainlabel.ForeColor = System.Drawing.Color.White;
            this.budgetremainlabel.Location = new System.Drawing.Point(434, 122);
            this.budgetremainlabel.Name = "budgetremainlabel";
            this.budgetremainlabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.budgetremainlabel.Size = new System.Drawing.Size(406, 88);
            this.budgetremainlabel.TabIndex = 5;
            this.budgetremainlabel.Text = "Total Uncollected Dues:";
            this.budgetremainlabel.Click += new System.EventHandler(this.budgetremainlabel_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.budgetremainlabel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.third;
            // 
            // third
            // 
            this.third.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.third.BackColor = System.Drawing.Color.Gray;
            this.third.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.third.ForeColor = System.Drawing.Color.White;
            this.third.Location = new System.Drawing.Point(22, 122);
            this.third.Name = "third";
            this.third.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.third.Size = new System.Drawing.Size(406, 88);
            this.third.TabIndex = 29;
            this.third.Text = "Total Charged Amount:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Top Amount Paid Sources:";
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
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.budmangrid;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(839, 259);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 340);
            this.guna2VScrollBar1.TabIndex = 27;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.Value = 1;
            // 
            // budmangrid
            // 
            this.budmangrid.AllowUserToAddRows = false;
            this.budmangrid.AllowUserToDeleteRows = false;
            this.budmangrid.AllowUserToResizeColumns = false;
            this.budmangrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.budmangrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budmangrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.budmangrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budmangrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.budmangrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.Location = new System.Drawing.Point(16, 259);
            this.budmangrid.MultiSelect = false;
            this.budmangrid.Name = "budmangrid";
            this.budmangrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.budmangrid.RowHeadersVisible = false;
            this.budmangrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.budmangrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.budmangrid.ShowCellErrors = false;
            this.budmangrid.ShowCellToolTips = false;
            this.budmangrid.ShowEditingIcon = false;
            this.budmangrid.ShowRowErrors = false;
            this.budmangrid.Size = new System.Drawing.Size(841, 340);
            this.budmangrid.TabIndex = 30;
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
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.budmangrid);
            this.Controls.Add(this.third);
            this.Controls.Add(this.budgetremainlabel);
            this.Controls.Add(this.totalfundslabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(873, 616);
            this.ClientSizeChanged += new System.EventHandler(this.Dashboard_ClientSizeChanged);
            this.Enter += new System.EventHandler(this.Dashboard_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label totalfundslabel;
        private System.Windows.Forms.Label budgetremainlabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private System.Windows.Forms.Label third;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2DataGridView budmangrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn charge;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm_id;
    }
}

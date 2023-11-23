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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.recentdatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.totalfundslabel = new System.Windows.Forms.Label();
            this.budgetremainlabel = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.refresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.recentdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // recentdatagrid
            // 
            this.recentdatagrid.AllowUserToAddRows = false;
            this.recentdatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.recentdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.recentdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentdatagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recentdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.recentdatagrid.ColumnHeadersHeight = 35;
            this.recentdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.desc,
            this.categ,
            this.amount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.recentdatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.recentdatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentdatagrid.Location = new System.Drawing.Point(12, 194);
            this.recentdatagrid.MultiSelect = false;
            this.recentdatagrid.Name = "recentdatagrid";
            this.recentdatagrid.ReadOnly = true;
            this.recentdatagrid.RowHeadersVisible = false;
            this.recentdatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.recentdatagrid.Size = new System.Drawing.Size(694, 271);
            this.recentdatagrid.TabIndex = 6;
            this.recentdatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.recentdatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.recentdatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.recentdatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.recentdatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.recentdatagrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.recentdatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentdatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.recentdatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.recentdatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentdatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.recentdatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.recentdatagrid.ThemeStyle.HeaderStyle.Height = 35;
            this.recentdatagrid.ThemeStyle.ReadOnly = true;
            this.recentdatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.recentdatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.recentdatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentdatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.recentdatagrid.ThemeStyle.RowsStyle.Height = 22;
            this.recentdatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.recentdatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // categ
            // 
            this.categ.HeaderText = "Category";
            this.categ.Name = "categ";
            this.categ.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
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
            this.totalfundslabel.Location = new System.Drawing.Point(12, 13);
            this.totalfundslabel.Name = "totalfundslabel";
            this.totalfundslabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.totalfundslabel.Size = new System.Drawing.Size(277, 125);
            this.totalfundslabel.TabIndex = 4;
            this.totalfundslabel.Text = "Total Funds:";
            // 
            // budgetremainlabel
            // 
            this.budgetremainlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetremainlabel.BackColor = System.Drawing.Color.Gray;
            this.budgetremainlabel.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.budgetremainlabel.ForeColor = System.Drawing.Color.White;
            this.budgetremainlabel.Location = new System.Drawing.Point(304, 13);
            this.budgetremainlabel.Name = "budgetremainlabel";
            this.budgetremainlabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.budgetremainlabel.Size = new System.Drawing.Size(309, 125);
            this.budgetremainlabel.TabIndex = 5;
            this.budgetremainlabel.Text = "Budget Remaining:";
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
            this.guna2Elipse3.TargetControl = this.recentdatagrid;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recents:";
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh.Animated = true;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.BorderRadius = 10;
            this.refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.refresh.FillColor = System.Drawing.Color.Teal;
            this.refresh.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageSize = new System.Drawing.Size(30, 30);
            this.refresh.Location = new System.Drawing.Point(628, 13);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(71, 125);
            this.refresh.TabIndex = 18;
            this.refresh.UseTransparentBackground = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.recentdatagrid);
            this.Controls.Add(this.budgetremainlabel);
            this.Controls.Add(this.totalfundslabel);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(719, 478);
            ((System.ComponentModel.ISupportInitialize)(this.recentdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView recentdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn categ;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label totalfundslabel;
        private System.Windows.Forms.Label budgetremainlabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button refresh;
    }
}

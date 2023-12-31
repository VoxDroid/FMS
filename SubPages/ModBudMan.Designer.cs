﻿using System;

namespace SPAAT.SubPages
{
    partial class ModBudMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModBudMan));
            this.nametb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.budgetstatuslabel = new System.Windows.Forms.Label();
            this.remtb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.alloctb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.categorytb = new Guna.UI2.WinForms.Guna2TextBox();
            this.categorylabel = new System.Windows.Forms.Label();
            this.crebud = new System.Windows.Forms.Label();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            this.modify = new Guna.UI2.WinForms.Guna2Button();
            this.createbudget = new Guna.UI2.WinForms.Guna2Button();
            this.budmangrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alloc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rembud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchlabel = new System.Windows.Forms.Label();
            this.searchtextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.recentstudentscb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.sbo = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).BeginInit();
            this.SuspendLayout();
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
            this.nametb.MaxLength = 50;
            this.nametb.Name = "nametb";
            this.nametb.PasswordChar = '\0';
            this.nametb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nametb.PlaceholderText = "Name...";
            this.nametb.SelectedText = "";
            this.nametb.Size = new System.Drawing.Size(267, 41);
            this.nametb.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 36);
            this.label3.TabIndex = 44;
            this.label3.Text = "Name";
            // 
            // budgetstatuslabel
            // 
            this.budgetstatuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetstatuslabel.Enabled = false;
            this.budgetstatuslabel.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.budgetstatuslabel.Location = new System.Drawing.Point(320, 385);
            this.budgetstatuslabel.Name = "budgetstatuslabel";
            this.budgetstatuslabel.Size = new System.Drawing.Size(416, 36);
            this.budgetstatuslabel.TabIndex = 43;
            this.budgetstatuslabel.Text = "BSL";
            this.budgetstatuslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.budgetstatuslabel.Visible = false;
            this.budgetstatuslabel.Click += new System.EventHandler(this.budgetstatuslabel_Click);
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
            this.remtb.Enabled = false;
            this.remtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remtb.Font = new System.Drawing.Font("Poppins", 10F);
            this.remtb.ForeColor = System.Drawing.Color.Black;
            this.remtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remtb.Location = new System.Drawing.Point(41, 362);
            this.remtb.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.remtb.MaxLength = 9;
            this.remtb.Name = "remtb";
            this.remtb.PasswordChar = '\0';
            this.remtb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.remtb.PlaceholderText = "Remaining...";
            this.remtb.SelectedText = "";
            this.remtb.Size = new System.Drawing.Size(267, 41);
            this.remtb.TabIndex = 42;
            this.remtb.TextChanged += new System.EventHandler(this.remtb_TextChanged);
            this.remtb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remtb_KeyDown);
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
            this.label2.TabIndex = 41;
            this.label2.Text = "Remaining Budget";
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
            this.alloctb.MaxLength = 9;
            this.alloctb.Name = "alloctb";
            this.alloctb.PasswordChar = '\0';
            this.alloctb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.alloctb.PlaceholderText = "Allocation...";
            this.alloctb.SelectedText = "";
            this.alloctb.Size = new System.Drawing.Size(267, 41);
            this.alloctb.TabIndex = 40;
            this.alloctb.TextChanged += new System.EventHandler(this.alloctb_TextChanged);
            this.alloctb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alloctb_KeyDown);
            this.alloctb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly2Alloc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Allocation Amount";
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
            this.categorytb.MaxLength = 100;
            this.categorytb.Name = "categorytb";
            this.categorytb.PasswordChar = '\0';
            this.categorytb.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.categorytb.PlaceholderText = "Category...";
            this.categorytb.SelectedText = "";
            this.categorytb.Size = new System.Drawing.Size(267, 41);
            this.categorytb.TabIndex = 38;
            this.categorytb.TextChanged += new System.EventHandler(this.categorytb_TextChanged);
            this.categorytb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.categorytb_KeyPress);
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.categorylabel.ForeColor = System.Drawing.Color.White;
            this.categorylabel.Location = new System.Drawing.Point(35, 150);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(113, 36);
            this.categorylabel.TabIndex = 37;
            this.categorylabel.Text = "Category";
            // 
            // crebud
            // 
            this.crebud.AutoSize = true;
            this.crebud.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.crebud.ForeColor = System.Drawing.Color.White;
            this.crebud.Location = new System.Drawing.Point(13, 14);
            this.crebud.Name = "crebud";
            this.crebud.Size = new System.Drawing.Size(186, 48);
            this.crebud.TabIndex = 36;
            this.crebud.Text = "Modify Item";
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
            this.delete.Location = new System.Drawing.Point(196, 424);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(176, 56);
            this.delete.TabIndex = 35;
            this.delete.Text = "Back";
            this.delete.UseTransparentBackground = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
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
            this.modify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modify.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(378, 424);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(176, 56);
            this.modify.TabIndex = 34;
            this.modify.Text = "Clear";
            this.modify.UseTransparentBackground = true;
            this.modify.Click += new System.EventHandler(this.clear_Click);
            // 
            // createbudget
            // 
            this.createbudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.createbudget.Location = new System.Drawing.Point(560, 424);
            this.createbudget.Name = "createbudget";
            this.createbudget.Size = new System.Drawing.Size(176, 56);
            this.createbudget.TabIndex = 33;
            this.createbudget.Text = "Modify";
            this.createbudget.UseTransparentBackground = true;
            this.createbudget.Click += new System.EventHandler(this.modifydata_Click);
            // 
            // budmangrid
            // 
            this.budmangrid.AllowUserToAddRows = false;
            this.budmangrid.AllowUserToDeleteRows = false;
            this.budmangrid.AllowUserToResizeColumns = false;
            this.budmangrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Poppins", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.budmangrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.budmangrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budmangrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.budmangrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.budmangrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.budmangrid.ColumnHeadersHeight = 30;
            this.budmangrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cat,
            this.alloc,
            this.rembud,
            this.id});
            this.budmangrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.budmangrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.budmangrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.budmangrid.Location = new System.Drawing.Point(320, 65);
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
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Poppins", 9F);
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
            this.budmangrid.Size = new System.Drawing.Size(416, 303);
            this.budmangrid.TabIndex = 47;
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
            this.budmangrid.ThemeStyle.HeaderStyle.Height = 30;
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
            // cat
            // 
            this.cat.HeaderText = "Category";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            // 
            // alloc
            // 
            this.alloc.HeaderText = "Allocation Amount";
            this.alloc.Name = "alloc";
            this.alloc.ReadOnly = true;
            // 
            // rembud
            // 
            this.rembud.HeaderText = "Remaining Budget";
            this.rembud.Name = "rembud";
            this.rembud.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // searchlabel
            // 
            this.searchlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlabel.AutoSize = true;
            this.searchlabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlabel.ForeColor = System.Drawing.Color.White;
            this.searchlabel.Location = new System.Drawing.Point(432, 17);
            this.searchlabel.Name = "searchlabel";
            this.searchlabel.Size = new System.Drawing.Size(76, 28);
            this.searchlabel.TabIndex = 49;
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
            this.searchtextbox.Location = new System.Drawing.Point(515, 8);
            this.searchtextbox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.PasswordChar = '\0';
            this.searchtextbox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.searchtextbox.PlaceholderText = "Search...";
            this.searchtextbox.SelectedText = "";
            this.searchtextbox.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.searchtextbox.Size = new System.Drawing.Size(176, 42);
            this.searchtextbox.TabIndex = 48;
            this.searchtextbox.TextChanged += new System.EventHandler(this.searchtextbox_TextChanged);
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
            this.guna2VScrollBar1.Location = new System.Drawing.Point(735, 97);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 10;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(10, 303);
            this.guna2VScrollBar1.TabIndex = 50;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.Value = 1;
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
            // recentstudentscb
            // 
            this.recentstudentscb.BackColor = System.Drawing.Color.Transparent;
            this.recentstudentscb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recentstudentscb.BorderRadius = 10;
            this.recentstudentscb.BorderThickness = 2;
            this.recentstudentscb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.recentstudentscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recentstudentscb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recentstudentscb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.recentstudentscb.Font = new System.Drawing.Font("Poppins", 10F);
            this.recentstudentscb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.recentstudentscb.ItemHeight = 30;
            this.recentstudentscb.Items.AddRange(new object[] {
            "-- Recent --"});
            this.recentstudentscb.Location = new System.Drawing.Point(154, 150);
            this.recentstudentscb.Name = "recentstudentscb";
            this.recentstudentscb.Size = new System.Drawing.Size(154, 36);
            this.recentstudentscb.StartIndex = 0;
            this.recentstudentscb.TabIndex = 64;
            this.recentstudentscb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.recentstudentscb.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.recentstudentscb.SelectedIndexChanged += new System.EventHandler(this.recentstudentscb_SelectedIndexChanged);
            this.recentstudentscb.Click += new System.EventHandler(this.recentstudentscb_Click);
            // 
            // sbo
            // 
            this.sbo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbo.BackColor = System.Drawing.Color.Transparent;
            this.sbo.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.sbo.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbo.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Image = ((System.Drawing.Image)(resources.GetObject("sbo.Image")));
            this.sbo.ImageOffset = new System.Drawing.Point(0, 0);
            this.sbo.ImageRotate = 0F;
            this.sbo.ImageSize = new System.Drawing.Size(30, 30);
            this.sbo.Location = new System.Drawing.Point(698, 8);
            this.sbo.Name = "sbo";
            this.sbo.Size = new System.Drawing.Size(38, 42);
            this.sbo.TabIndex = 66;
            this.sbo.UseTransparentBackground = true;
            this.sbo.CheckedChanged += new System.EventHandler(this.sbo_CheckedChanged);
            // 
            // ModBudMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.sbo);
            this.Controls.Add(this.recentstudentscb);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.searchlabel);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.budmangrid);
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
            this.DoubleBuffered = true;
            this.Name = "ModBudMan";
            this.Size = new System.Drawing.Size(750, 500);
            this.Load += new System.EventHandler(this.ModBudMan_Load);
            this.Enter += new System.EventHandler(this.ModBudMan_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.budmangrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Guna.UI2.WinForms.Guna2TextBox nametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label budgetstatuslabel;
        private Guna.UI2.WinForms.Guna2TextBox remtb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox alloctb;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox categorytb;
        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label crebud;
        private Guna.UI2.WinForms.Guna2Button delete;
        private Guna.UI2.WinForms.Guna2Button modify;
        private Guna.UI2.WinForms.Guna2Button createbudget;
        private Guna.UI2.WinForms.Guna2DataGridView budmangrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn rembud;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label searchlabel;
        private Guna.UI2.WinForms.Guna2TextBox searchtextbox;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2ComboBox recentstudentscb;
        private Guna.UI2.WinForms.Guna2ImageCheckBox sbo;
    }
}

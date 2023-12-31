﻿using Bunifu.UI.WinForms;
using SPAAT.Pages;
using SPAAT.SubPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using MySql.Data.MySqlClient;
using static Guna.UI2.Native.WinApi;
using Guna.UI2.WinForms;

namespace SPAAT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            appbar.MouseDown += new MouseEventHandler(label1_MouseDown);
            Admin();
            guna2HtmlToolTip1.SetToolTip(ZAPISAXIS, "© 2023 Copyright: Mhar Andrei Macapallag");
            guna2HtmlToolTip1.SetToolTip(guna2Button1, "Log out and go to the login page.");

            this.Resize += Form_Resize;
        }

        private const int MinFormWidth = 1000;
        private const int MinFormHeight = 800;

        private void Form_Resize(object sender, EventArgs e)
        {
            if (this.Width < MinFormWidth)
            {
                this.Width = MinFormWidth;
            }

            if (this.Height < MinFormHeight)
            {
                this.Height = MinFormHeight;
            }
        }

        private bool IsSuperUser(string username)
        {
            string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                connection.Open();

                string getUserIdQuery = "SELECT user_id FROM users WHERE username = @username";
                string checkSuperUserQuery = "SELECT COUNT(*) FROM su WHERE user_id = @userId";

                using (MySqlCommand getUserIdCommand = new MySqlCommand(getUserIdQuery, connection))
                {
                    getUserIdCommand.Parameters.AddWithValue("@username", username);

                    int userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());

                    using (MySqlCommand checkSuperUserCommand = new MySqlCommand(checkSuperUserQuery, connection))
                    {
                        checkSuperUserCommand.Parameters.AddWithValue("@userId", userId);

                        int count = Convert.ToInt32(checkSuperUserCommand.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
        }

        public BunifuPages GetPagesControl()
        {
            return pages;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


        private string loggedInUser;

        public string LoggedInUser
        {
            get { return loggedInUser; }
            set
            {
                loggedInUser = value;
                appbar.Text = $"SOCCS Financial Management System     |     Logged in as: {loggedInUser}";
                this.Text = $"ZAPISAXIS - {loggedInUser}";
                Admin();
            }
        }

        private void Admin()
        {
            bool isSuperUser = IsSuperUser(loggedInUser);
            adminpage.Enabled = isSuperUser;
            adminpage.Visible = isSuperUser;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoggedInUser = "DefaultUser";
        }
        
        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            pages.SelectTab(dashboardpage);
            this.Text = $"ZAPISAXIS - Dashboard - {loggedInUser}";
            
        }

        private void budgetmanagement_Click(object sender, EventArgs e)
        {
            pages.SelectTab(budman);
            this.Text = $"ZAPISAXIS - Budget Management - {loggedInUser}";
        }

        private void logs_Click(object sender, EventArgs e)
        {
            pages.SelectTab(log);
            this.Text = $"ZAPISAXIS - Transaction Logs - {loggedInUser}";
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            pages.SelectTab(setting);
            this.Text = $"ZAPISAXIS - Settings - {loggedInUser}";
        }

        private void exportf_Click(object sender, EventArgs e)
        {
            pages.SelectTab(export);
            this.Text = $"ZAPISAXIS - Export - {loggedInUser}";
        }

        private void adminpage_Click(object sender, EventArgs e)
        {
            pages.SelectTab(admins);
            this.Text = $"ZAPISAXIS - Admin - {loggedInUser}";
        }

        private void studentfile_Click(object sender, EventArgs e)
        {
            pages.SelectTab(studfil);
            this.Text = $"ZAPISAXIS - Student File - {loggedInUser}";
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ClosingTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
            {
                Opacity -= 0.05;
            }
            else if (Opacity == 0)
            {
                this.Visible = false;
                Environment.Exit(1);
            }
        }
        private Timer closingTimer;
        private void exit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            closingTimer = new Timer();
            closingTimer.Interval = 10;
            closingTimer.Tick += (s, args) =>
            {
                ClosingTimer_Tick(s, e);
            };
            closingTimer.Start();
            main.Visible = true;
        }

        private void appbar_Click(object sender, EventArgs e)
        {

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void budgetManagement1_Load(object sender, EventArgs e)
        {

        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void pages_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                    e.Handled = true;
                    break;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void pages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

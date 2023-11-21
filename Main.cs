using Bunifu.UI.WinForms;
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

namespace SPAAT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            appbar.MouseDown += new MouseEventHandler(label1_MouseDown);
        }

        public BunifuPages mypages
        {
            get { return pages; }
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
            }
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
    }
}

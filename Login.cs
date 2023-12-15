using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using SPAAT.Pages;
using SPAAT.SubPages;

namespace SPAAT
{
    public partial class Login : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        private Guna2Transition formTransition;
        private int targetX = 12;
        private int targetY = 12;
        private int target2X = 75;
        private int target2Y = 438;
        private int target3X = 75;
        private int target3Y = 360;
        private int target4X = -5;
        private int target4Y = 646;
        private int duration = 5000;
        private int targetsetbuttonx = 13;
        private int targetsetbuttony = 616;
        private int targetsetshapex = -119;
        private int targetsetshapey = 571;
        //settings unchecked
        private int controlcontainerx = 231;
        private int controlcontainery = 608;
        private int exitx = 421;
        private int exity = 616;
        private int minimizex = 343;
        private int minimizey = 616;
        private int infox = 265;
        private int infoy = 616;
        //settings checked
        private int rcontrolcontainerx = 231;
        private int rcontrolcontainery = 650;
        private int rexitx = 421;
        private int rexity = 650;
        private int rminimizex = 343;
        private int rminimizey = 650;
        private int rinfox = 265;
        private int rinfoy = 650;
        private DateTime animationStartTime;
        private Timer animationTimer;
        private Timer timer2;
        private bool animationCompleted = false;
        private Timer buttonDisappearTimer;
        private Timer showContinueAnimationTimer;
        private Timer loadingappear;

        private Timer loadingLabelTimer;
        private int loadingLabelDots = 1;

        private bool buttondisappear = false;
        private bool blocker2 = false;


        private Timer login;
        private Timer settings;
        private Timer settings2;
        private Timer settings3;

        public Login()
        {
            DatabaseInitializer.InitializeDatabase();
            connection = new MySqlConnection(connectionString);

            InitializeComponent();
            this.Load += Login_Load;
            Blocker.Enabled = false;
            Blocker.Visible = false;


            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.Resize += (sender, e) =>
            {
                this.Size = new Size(459, 648);
            };

            guna2HtmlToolTip1.SetToolTip(info, "If you lost your access to the system, click here.");
        }

        private Timer closingTimer;
        private int closingDuration = 500;

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

        private void Login_Load(object sender, EventArgs e)
        {
            controlcontainer.Location = new Point(231, 650);
            exit.Location = new Point(421, 650);
            minimize.Location = new Point(343, 650);
            info.Location = new Point(265, 650);

            controlboxcheck.Location = new Point(-30, 650);
            controlbox.Location = new Point(-140, 650);
            guna2Button1.Visible = false;

            loadingappear = new Timer();
            loadingappear.Interval = 1000;
            loadingappear.Start();

            animationTimer = new Timer();
            animationTimer.Interval = 5;
            animationTimer.Tick += AnimationTimer_Tick;

            settings2 = new Timer();
            settings2.Interval = 5;
            settings2.Tick += settings_Tick;

            settings3 = new Timer();
            settings3.Interval = 5;
            settings3.Tick += settingsback_Tick;

            timer2 = new Timer();
            timer2.Interval = 3000;
            timer2.Tick += Timer2_Tick;
            timer2.Start();
            buttonDisappearTimer = new Timer();
            buttonDisappearTimer.Interval = 3500;
            buttonDisappearTimer.Tick += ButtonDisappearTimer_Tick;

            loadingLabelTimer = new Timer();
            loadingLabelTimer.Interval = 500;
            loadingLabelTimer.Tick += LoadingLabelTimer_Tick;
            loadingLabelTimer.Start();

            showControlsTimer = new Timer();
            showControlsTimer.Interval = 1000;
            showControlsTimer.Tick += ShowControlsTimer_Tick;
        }

        private void LoadingLabelTimer_Tick(object sender, EventArgs e)
        {
            string loadingText = "Loading";
            for (int i = 0; i < loadingLabelDots; i++)
            {
                loadingText += ".";
            }
            loadingLabel.Text = loadingText;

            loadingLabelDots = (loadingLabelDots % 3) + 1;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            Loading.Enabled = false;
            Loading.AutoStart = false;

            if (!animationCompleted)
            {
                guna2Button1.Click += guna2Button1_Click;
                animationStartTime = DateTime.Now;
                showContinueAnimationTimer = new Timer();
                showContinueAnimationTimer.Interval = 10;
                showContinueAnimationTimer.Tick += ShowContinueAnimationTimer_Tick;
                showContinueAnimationTimer.Start();
            }
        }


        private void ShowContinueAnimationTimer_Tick(object sender, EventArgs e)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= duration)
            {
                showContinueAnimationTimer.Stop();
            }
            else
            {
                double progress = elapsedMilliseconds / duration;

                int currentX3 = (int)(ShowContinue.Location.X + (target3X - ShowContinue.Location.X) * progress);
                int currentY3 = (int)(ShowContinue.Location.Y + (target3Y - ShowContinue.Location.Y) * progress);
                ShowContinue.Location = new Point(currentX3, currentY3);

                int currentX4 = (int)(Loading.Location.X + (181 - Loading.Location.X) * progress);
                int currentY4 = (int)(Loading.Location.Y + (700 - Loading.Location.Y) * progress);
                Loading.Location = new Point(currentX4, currentY4);

                int currentX5 = (int)(loadingLabel.Location.X + (188 - loadingLabel.Location.X) * progress);
                int currentY5 = (int)(loadingLabel.Location.Y + (700 - loadingLabel.Location.Y) * progress);
                loadingLabel.Location = new Point(currentX5, currentY5);

                int currentX6 = (int)(blockerloader.Location.X + (88 - blockerloader.Location.X) * progress);
                int currentY6 = (int)(blockerloader.Location.Y + (580 - blockerloader.Location.Y) * progress);
                blockerloader.Location = new Point(currentX6, currentY6);
            }
        }

        private Timer showControlsTimer;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!animationCompleted)
            {
                animationStartTime = DateTime.Now;
                animationTimer.Start();
                buttonDisappearTimer.Start();
                ShowContinue.Visible = false;
                ShowContinue.Enabled = false;
                ShowContinue.Location = new Point(999, 999);
                Loading.Visible = false;
                Loading.Enabled = false;
                Loading.Location = new Point(999, 999);
                loadingLabel.Enabled = false;
                loadingLabel.Visible = false;
                Loading.Location = new Point(999, 999);
                blockerloader.Enabled = false;
                blockerloader.Visible = false;
                blockerloader.Location = new Point(999, 999);
                showControlsTimer.Start();
            }

        }

        private void ShowControlsTimer_Tick(object sender, EventArgs e)
        {
            showControlsTimer.Stop();
            ShowControls();
        }

        private void ButtonDisappearTimer_Tick(object sender, EventArgs e)
        {
            buttonDisappearTimer.Stop();
            buttondisappear = true;
        }


        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= duration)
            {
                animationTimer.Stop();
                animationCompleted = true;


                HideContinue.Visible = false;
                HideContinue.Enabled = false;
                HideContinue.Location = new Point(999, 999);
                guna2Button1.Visible = false;
                guna2Button1.Enabled = false;
                guna2Button1.Location = new Point(999, 999);

                if (animationCompleted)
                {
                    ShowControls();
                }
            }
            else
            {
                double progress = elapsedMilliseconds / duration;

                int currentX = (int)(Logo.Location.X + (targetX - Logo.Location.X) * progress);
                int currentY = (int)(Logo.Location.Y + (targetY - Logo.Location.Y) * progress);

                Logo.Location = new Point(currentX, currentY);

                int currentX2 = (int)(HideContinue.Location.X + (target2X - HideContinue.Location.X) * progress);
                int currentY2 = (int)(HideContinue.Location.Y + (target2Y - HideContinue.Location.Y) * progress);

                HideContinue.Location = new Point(currentX2, currentY2);

            }


        }

        private int movePixelsX;
        private int movePixelsY;
        private int movePixels2X;
        private int movePixels2Y;
        private int movePixels3X;
        private int movePixels3Y;
        private int blocker2Duration = 35000;
        private int settings2Duration = 35000;
        private int duration2;

        private void ShowControls()
        {
            username.Enabled = true;
            username.Visible = true;
            password.Enabled = true;
            password.Visible = true;
            loginbutton.Enabled = true;
            loginbutton.Visible = true;
            Blocker2.Enabled = true;
            Blocker2.Visible = true;
            controlbox.Enabled = true;
            controlbox.Visible = true;
            controlboxcheck.Enabled = true;
            controlboxcheck.Visible = true;

            login = new Timer();
            login.Interval = 1;
            login.Tick += login_Tick;
            login.Start();

            settings = new Timer();
            settings.Interval = 1;

            duration = blocker2Duration;
            duration2 = settings2Duration;

            target4X = 600;
            target4Y = 220;
            targetsetbuttonx = 13;
            targetsetbuttony = 616;
            targetsetshapex = -119;
            targetsetshapey = 571;

            int totalTicks = (int)(duration / login.Interval);
            movePixelsX = (target4X - Blocker2.Location.X) / totalTicks;
            movePixelsY = (target4Y - Blocker2.Location.Y) / totalTicks;

            int totalTicks2 = (int)(duration2 / settings.Interval);

            movePixels2X = (targetsetbuttonx - controlboxcheck.Location.X) / totalTicks2;
            movePixels2Y = (targetsetbuttony - controlboxcheck.Location.Y) / totalTicks2;

            movePixels3X = (targetsetshapex - controlbox.Location.X) / totalTicks2;
            movePixels3Y = (targetsetshapey - controlbox.Location.Y) / totalTicks2;
        }

        private void login_Tick(object sender, EventArgs e)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= duration)
            {
                login.Stop();
                blocker2 = true;
            }
            else
            {
                double progress = elapsedMilliseconds / duration;

                int currentX3 = (int)(Blocker2.Location.X + (target4X - Blocker2.Location.X) * progress);
                int currentY3 = (int)(Blocker2.Location.Y + (target4Y - Blocker2.Location.Y) * progress);
                Blocker2.Location = new Point(currentX3, currentY3);

                int currentX4 = (int)(controlboxcheck.Location.X + (targetsetbuttonx - controlboxcheck.Location.X) * progress);
                int currentY4 = (int)(controlboxcheck.Location.Y + (targetsetbuttony - controlboxcheck.Location.Y) * progress);
                controlboxcheck.Location = new Point(currentX4, currentY4);

                int currentX5 = (int)(controlbox.Location.X + (targetsetshapex - controlbox.Location.X) * progress);
                int currentY5 = (int)(controlbox.Location.Y + (targetsetshapey - controlbox.Location.Y) * progress);
                controlbox.Location = new Point(currentX5, currentY5);
            }
        }

        private void Hover(object sender, MouseEventArgs e)
        {
            if (buttondisappear == true)
            {
                HideContinue.Visible = false;
                HideContinue.Enabled = false;
                HideContinue.Location = new Point(999, 999);
                guna2Button1.Visible = false;
                guna2Button1.Enabled = false;
                guna2Button1.Location = new Point(999, 999);
            }
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!passwordshow.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private bool settingsAnimating = false;
        private Timer settingsTimer;
        private Timer settingsbackTimer;
        private int settingsDuration = 500;
        private bool checkboxCooldown = false;
        private Timer checkboxCooldownTimer;

        private void guna2ImageCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            controlcontainer.Visible = true;
            controlcontainer.Enabled = true;
            exit.Enabled = true;
            exit.Visible = true;
            minimize.Enabled = true;
            minimize.Visible = true;
            info.Visible = true;
            info.Enabled = true;
            if (!checkboxCooldown)
            {
                checkboxCooldown = true;
                checkboxCooldownTimer = new Timer();
                checkboxCooldownTimer.Interval = 500;
                checkboxCooldownTimer.Tick += (s, args) => checkboxCooldown = false;
                checkboxCooldownTimer.Start();

                if (controlboxcheck.Checked && !settingsAnimating)
                {
                    settingsAnimating = true;
                    animationStartTime = DateTime.Now;

                    settingsTimer = new Timer();
                    settingsTimer.Interval = 5;
                    settingsTimer.Tick += (s, args) => AnimateSettings(true);
                    settingsTimer.Start();
                }
                else if (!controlboxcheck.Checked && !settingsAnimating)
                {
                    settingsAnimating = true;
                    animationStartTime = DateTime.Now;

                    settingsbackTimer = new Timer();
                    settingsbackTimer.Interval = 5;
                    settingsbackTimer.Tick += (s, args) => AnimateSettings(false);
                    settingsbackTimer.Start();
                }
            }
        }

        private void AnimateSettings(bool forward)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= settingsDuration)
            {
                settingsAnimating = false;
                settingsTimer?.Stop();
                settingsbackTimer?.Stop();
            }
            else
            {
                double progress = elapsedMilliseconds / settingsDuration;

                int currentX = forward ?
                    (int)(controlcontainer.Location.X + (controlcontainerx - controlcontainer.Location.X) * progress) :
                    (int)(controlcontainer.Location.X + (rcontrolcontainerx - controlcontainer.Location.X) * progress);

                int currentY = forward ?
                    (int)(controlcontainer.Location.Y + (controlcontainery - controlcontainer.Location.Y) * progress) :
                    (int)(controlcontainer.Location.Y + (rcontrolcontainery - controlcontainer.Location.Y) * progress);

                controlcontainer.Location = new Point(currentX, currentY);

                int currentX2 = forward ?
                    (int)(exit.Location.X + (exitx - exit.Location.X) * progress) :
                    (int)(exit.Location.X + (rexitx - exit.Location.X) * progress);

                int currentY2 = forward ?
                    (int)(exit.Location.Y + (exity - exit.Location.Y) * progress) :
                    (int)(exit.Location.Y + (rexity - exit.Location.Y) * progress);

                exit.Location = new Point(currentX2, currentY2);

                int currentX3 = forward ?
                    (int)(minimize.Location.X + (minimizex - minimize.Location.X) * progress) :
                    (int)(minimize.Location.X + (rminimizex - minimize.Location.X) * progress);

                int currentY3 = forward ?
                    (int)(minimize.Location.Y + (minimizey - minimize.Location.Y) * progress) :
                    (int)(minimize.Location.Y + (rminimizey - minimize.Location.Y) * progress);

                minimize.Location = new Point(currentX3, currentY3);

                int currentX4 = forward ?
                    (int)(info.Location.X + (infox - info.Location.X) * progress) :
                    (int)(info.Location.X + (rinfox - info.Location.X) * progress);

                int currentY4 = forward ?
                    (int)(info.Location.Y + (infoy - info.Location.Y) * progress) :
                    (int)(info.Location.Y + (rinfoy - info.Location.Y) * progress);

                info.Location = new Point(currentX4, currentY4);
            }
        }

        private void settings_Tick(object sender, EventArgs e)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= duration)
            {
                settings2.Stop();
            }
            else
            {
                double progress = elapsedMilliseconds / duration;

                int currentX = (int)(controlcontainer.Location.X + (controlcontainerx - controlcontainer.Location.X) * progress);
                int currentY = (int)(controlcontainer.Location.Y + (controlcontainery - controlcontainer.Location.Y) * progress);

                controlcontainer.Location = new Point(currentX, currentY);

                int currentX2 = (int)(exit.Location.X + (exitx - exit.Location.X) * progress);
                int currentY2 = (int)(exit.Location.Y + (exity - exit.Location.Y) * progress);

                exit.Location = new Point(currentX2, currentY2);

                int currentX3 = (int)(minimize.Location.X + (minimizex - minimize.Location.X) * progress);
                int currentY3 = (int)(minimize.Location.Y + (minimizey - minimize.Location.Y) * progress);

                minimize.Location = new Point(currentX3, currentY3);

                int currentX4 = (int)(info.Location.X + (infox - info.Location.X) * progress);
                int currentY4 = (int)(info.Location.Y + (infoy - info.Location.Y) * progress);

                info.Location = new Point(currentX4, currentY4);

            }
        }
        private void settingsback_Tick(object sender, EventArgs e)
        {
            double elapsedMilliseconds = (DateTime.Now - animationStartTime).TotalMilliseconds;

            if (elapsedMilliseconds >= duration)
            {
                settings3.Stop();
            }
            else
            {
                double progress = elapsedMilliseconds / duration;

                int currentX = (int)(controlcontainer.Location.X + (rcontrolcontainerx - controlcontainer.Location.X) * progress);
                int currentY = (int)(controlcontainer.Location.Y + (rcontrolcontainery - controlcontainer.Location.Y) * progress);

                controlcontainer.Location = new Point(currentX, currentY);

                int currentX2 = (int)(exit.Location.X + (rexitx - exit.Location.X) * progress);
                int currentY2 = (int)(exit.Location.Y + (rexity - exit.Location.Y) * progress);

                exit.Location = new Point(currentX2, currentY2);

                int currentX3 = (int)(minimize.Location.X + (rminimizex - minimize.Location.X) * progress);
                int currentY3 = (int)(minimize.Location.Y + (rminimizey - minimize.Location.Y) * progress);

                minimize.Location = new Point(currentX3, currentY3);

                int currentX4 = (int)(info.Location.X + (rinfox - info.Location.X) * progress);
                int currentY4 = (int)(info.Location.Y + (rinfoy - info.Location.Y) * progress);

                info.Location = new Point(currentX4, currentY4);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            closingTimer = new Timer();
            closingTimer.Interval = 10;
            closingTimer.Tick += (s, args) =>
            {
                ClosingTimer_Tick(s, e);
            };
            closingTimer.Start();
            this.Visible = true;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string currentlyLoggedInUser;
        public string CurrentlyLoggedInUser
        {
            get { return currentlyLoggedInUser; }
        }

        private bool IsDatabaseConnected()
        {
            try
            {
                connection.Open();
                return connection.State == ConnectionState.Open;
            }
            catch (MySqlException)
            {
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            string username1 = username.Text;
            string password1 = password.Text;
            if (IsDatabaseConnected())
            {
                if (string.IsNullOrWhiteSpace(username1) || string.IsNullOrWhiteSpace(password1))
                {
                    lblError.Enabled = true;
                    lblError.Visible = true;
                    lblError.Text = "Please fill up all the fields.";
                }
                else
                {
                    string authenticatedUser = AuthenticateUser(username1, password1);

                    if (!string.IsNullOrEmpty(authenticatedUser))
                    {
                        currentlyLoggedInUser = authenticatedUser;

                        lblError.Enabled = false;
                        lblError.Visible = false;
                        lblError.Text = string.Empty;
                        Main mainForm = new Main();
                        mainForm.Show();
                        mainForm.LoggedInUser = currentlyLoggedInUser;

                        this.Hide();
                    }
                    else
                    {
                        lblError.Enabled = true;
                        lblError.Visible = true;
                        lblError.Text = "Invalid username or password.";
                    }
                }
            }
            else
            {
                MessageBox.Show($"Database error.");
                lblError.Enabled = true;
                lblError.Visible = true;
                lblError.Text = "Database Error.";
            }
        }

        private string AuthenticateUser(string username, string password)
        {
            try
            {
                connection.Open();
                string query = "SELECT Username, Password FROM Users WHERE Username = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedUsername = reader["Username"].ToString();
                        string storedPassword = reader["Password"].ToString();

                        bool isAuthenticated = storedUsername == username && storedPassword == password;

                        if (isAuthenticated)
                        {
                            return storedUsername;
                        }
                    }
                }

                return null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void Blocker2_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Focus();
                e.Handled = true;
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginEnter();
                e.Handled = true;
            }
        }

        private void LoginEnter()
        {
            lblError.Text = string.Empty;
            string username1 = username.Text;
            string password1 = password.Text;
            if (IsDatabaseConnected())
            {
                if (string.IsNullOrWhiteSpace(username1) || string.IsNullOrWhiteSpace(password1))
                {
                    lblError.Enabled = true;
                    lblError.Visible = true;
                    lblError.Text = "Please fill up all the fields.";
                }
                else
                {
                    string authenticatedUser = AuthenticateUser(username1, password1);

                    if (!string.IsNullOrEmpty(authenticatedUser))
                    {
                        currentlyLoggedInUser = authenticatedUser;

                        lblError.Enabled = false;
                        lblError.Visible = false;
                        lblError.Text = string.Empty;
                        Main mainForm = new Main();
                        mainForm.Show();
                        mainForm.LoggedInUser = currentlyLoggedInUser;

                        this.Hide();
                    }
                    else
                    {
                        lblError.Enabled = true;
                        lblError.Visible = true;
                        lblError.Text = "Invalid username or password.";
                    }
                }
            }
            else
            {
                MessageBox.Show($"Database error.");
                lblError.Enabled = true;
                lblError.Visible = true;
                lblError.Text = "Database Error.";
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            Recovery recover = new Recovery();
            recover.Show();
        }
    }
}

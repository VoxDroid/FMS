using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SPAAT.SubPages;
using System.Speech.Synthesis;
using System.Threading;

namespace SPAAT.Pages
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            guna2HtmlToolTip1.SetToolTip(logout, "Log out and go to the login page.");
            guna2HtmlToolTip1.SetToolTip(RBM, "Delete and reset all data stored in Budget Management.");
            guna2HtmlToolTip1.SetToolTip(RTL, "Delete and reset all data stored in Transaction Logs.");
        }


        private bool ConfirmDeletionWithResetKey()
        {
            string resetKeyFromDatabase = GetResetKeyFromDatabase();

            do
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the reset key to confirm deletion:", "Confirmation", "");

                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Reset Operation Canceled. No reset key entered.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (userInput.Trim().Equals(resetKeyFromDatabase, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect reset key. Please try again.", "Incorrect Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            while (true);
        }

        private string GetResetKeyFromDatabase()
        {
            string resetKey = "";

            try
            {
                string connet = "Server=localhost;Database=fms;Username=root;Password=;";

                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string selectQuery = "SELECT reset_key FROM resetkeys";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resetKey = reader["reset_key"].ToString();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resetKey;
        }

        private void RBM_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "Are you sure you want to delete all records from Budget Management?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        string connet = "Server=localhost;Database=fms;Username=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM budman";

                            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("All records deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No records found to delete.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RTL_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "Are you sure you want to delete all records from Budget Management?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        string connet = "Server=localhost;Database=fms;Username=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM tranlo";

                            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("All records deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No records found to delete.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }
    }
}

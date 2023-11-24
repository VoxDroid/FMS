using Bunifu.UI.WinForms;
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
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using Guna.UI2.WinForms;
namespace SPAAT.Pages
{
    public partial class AdminPage : UserControl
    {
        string connet = "Server=localhost;Database=fms;Username=root;Password=;";
        public AdminPage()
        {
            InitializeComponent();
            PopulateDataGridView();
            guna2HtmlToolTip1.SetToolTip(resetkeylabel, $"Reset Key is used for when resetting the database. {Environment.NewLine}Click to copy to clipboard.");
            try
            {
                string resetKey = GetResetKey();

                resetkeylabel.Text = $"Reset Key: {Environment.NewLine}{resetKey}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT user_id, username, password FROM users;";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        budmangrid.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid.Rows.Add();
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["user_id"];
                            budmangrid.Rows[rowIndex].Cells["username"].Value = row["username"];
                            budmangrid.Rows[rowIndex].Cells["password"].Value = row["password"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            FilterDataGridView(searchQuery);
        }

        private void FilterDataGridView(string searchQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM users " +
                              "WHERE username LIKE @searchQuery " +
                              "   OR password LIKE @searchQuery " +
                              "   OR user_id LIKE @searchQuery";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchQuery", $"%{searchQuery}%");

                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        budmangrid.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid.Rows.Add();
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["user_id"];
                            budmangrid.Rows[rowIndex].Cells["username"].Value = row["username"];
                            budmangrid.Rows[rowIndex].Cells["password"].Value = row["password"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            searchtextbox.Text = string.Empty;
        }

        private void budmangrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = budmangrid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = cell.Value?.ToString();

                if (!string.IsNullOrWhiteSpace(cellText))
                {
                    guna2HtmlToolTip1.SetToolTip(budmangrid, cellText);
                }
                else
                {
                    guna2HtmlToolTip1.SetToolTip(budmangrid, null);
                }
            }
        }

        private void budmangrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(budmangrid, null);
        }

        private void createbudget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text) || string.IsNullOrWhiteSpace(passtb.Text))
            {
                budgetstatuslabel.ForeColor = Color.Maroon;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Text = "Please fill in all the fields.";
            }
            else
            {
                string name = nametb.Text;
                string password = passtb.Text;

                if (IsUsernameExists(name))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Text = "Username already exists.";
                    return;
                }

                DateTime currentDate = DateTime.Now;

                string sqlInsert = "INSERT INTO users (username, password) " +
                                   "VALUES (@name, @password)";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connet))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlInsert, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@password", password);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                budgetstatuslabel.Enabled = true;
                                budgetstatuslabel.Visible = true;
                                budgetstatuslabel.ForeColor = Color.DarkGreen;
                                budgetstatuslabel.Text = "Record inserted successfully.";
                                nametb.Clear();
                                passtb.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert record.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool IsUsernameExists(string username)
        {
            string sqlCheckUsername = "SELECT COUNT(*) FROM users WHERE username = @username";

            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlCheckUsername, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void budmangrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (budmangrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = budmangrid.SelectedRows[0];

                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                if (IsSuperUser(selectedId))
                {
                    MessageBox.Show("Admin Account cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Text = "Admin Account cannot be deleted.";
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteRecord(selectedId);

                    PopulateDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsSuperUser(int userId)
        {
            string sqlCheckSuperUser = "SELECT COUNT(*) FROM su WHERE user_id = @userId";

            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlCheckSuperUser, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void DeleteRecord(int user_id)
        {
            string sqlDelete = "DELETE FROM users WHERE user_id = @user_id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlDelete, connection))
                    {
                        command.Parameters.AddWithValue("@user_id", user_id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete User Account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (budmangrid.SelectedRows.Count > 0)
            {
                string name = nametb.Text.Trim();
                string password = passtb.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(password))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Text = "Please fill in at least one field.";
                    return;
                }

                DataGridViewRow selectedRow = budmangrid.SelectedRows[0];
                int selectedRecordId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                string originalName = selectedRow.Cells["username"].Value.ToString();
                string originalPassword = selectedRow.Cells["password"].Value.ToString();

                StringBuilder confirmationMessage = new StringBuilder("Are you sure you want to update this record with the following changes?\n\n");

                if (!string.IsNullOrWhiteSpace(name) && name != originalName)
                    confirmationMessage.AppendLine($"Name: {originalName} → {name}");

                if (!string.IsNullOrWhiteSpace(password) && password != originalPassword)
                    confirmationMessage.AppendLine($"Password: {originalPassword} → {password}");

                DialogResult result = MessageBox.Show(confirmationMessage.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sqlUpdate = "UPDATE users SET username = @username, password = @password WHERE user_id = @user_id";

                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand(sqlUpdate, connection))
                            {
                                command.Parameters.AddWithValue("@username", string.IsNullOrWhiteSpace(name) ? originalName : name);
                                command.Parameters.AddWithValue("@password", string.IsNullOrWhiteSpace(password) ? originalPassword : password);
                                command.Parameters.AddWithValue("@user_id", selectedRecordId);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    budgetstatuslabel.Enabled = true;
                                    budgetstatuslabel.Visible = true;
                                    budgetstatuslabel.ForeColor = Color.DarkGreen;
                                    budgetstatuslabel.Text = "User Account updated successfully.";
                                }
                                else
                                {
                                    budgetstatuslabel.ForeColor = Color.Maroon;
                                    budgetstatuslabel.Visible = true;
                                    budgetstatuslabel.Enabled = true;
                                    budgetstatuslabel.Text = "Failed to update User Account.";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                budgetstatuslabel.ForeColor = Color.Maroon;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Text = "Please select a row to update.";
            }
        }

        private void clearb_Click(object sender, EventArgs e)
        {
            nametb.Text = string.Empty;
            passtb.Text = string.Empty;
            resettb.Text = string.Empty;
            searchtextbox.Text = string.Empty;
            budgetstatuslabel.ForeColor = Color.DarkGreen;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                string resetKeyInput = resettb.Text.Trim();

                if (string.IsNullOrWhiteSpace(resetKeyInput))
                {
                    MessageBox.Show("Please enter a valid reset key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetResetKey(resetKeyInput);

                resetkeylabel.Text = $"Reset Key: {Environment.NewLine}{resetKeyInput}";

                MessageBox.Show("Reset key set successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetResetKey(string resetKey)
        {
            string connet = "Server=localhost;Database=fms;Username=root;Password=;";

            string sqlCheckExistence = "SELECT COUNT(*) FROM resetkeys WHERE id = 1";
            string sqlInsert = "INSERT INTO resetkeys (id, reset_key) VALUES (1, @resetKey)";
            string sqlUpdate = "UPDATE resetkeys SET reset_key = @resetKey WHERE id = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand checkCommand = new MySqlCommand(sqlCheckExistence, connection))
                    {
                        int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (rowCount == 0)
                        {
                            using (MySqlCommand insertCommand = new MySqlCommand(sqlInsert, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@resetKey", resetKey);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (MySqlCommand updateCommand = new MySqlCommand(sqlUpdate, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@resetKey", resetKey);
                                updateCommand.ExecuteNonQuery();
                            }
                        }

                        budgetstatuslabel.Enabled = true;
                        budgetstatuslabel.Visible = true;
                        budgetstatuslabel.ForeColor = Color.DarkGreen;
                        budgetstatuslabel.Text = "Reset Key Set Successfully.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while setting reset key: " + ex.Message);
            }
        }

        private string GetResetKey()
        {
            string connet = "Server=localhost;Database=fms;Username=root;Password=;";

            string sqlSelect = "SELECT reset_key FROM resetkeys LIMIT 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlSelect, connection))
                    {
                        object result = command.ExecuteScalar();

                        return result != null ? result.ToString() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving reset key: " + ex.Message);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string randomResetKey = GenerateRandomResetKey(20);

            resettb.Text = randomResetKey;

        }

        private string GenerateRandomResetKey(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();

            string resetKey = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return resetKey;
        }

        private void resetkeylabel_Click(object sender, EventArgs e)
        {
            try
            {
                string resetKey = GetResetKey();

                if (!string.IsNullOrEmpty(resetKey))
                {
                    Clipboard.SetText(resetKey);
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.ForeColor = Color.DarkGreen;
                    budgetstatuslabel.Text = $"Reset key {resetKey} copied.";
                    MessageBox.Show($"Reset key {resetKey} copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Text = "No reset key available.";
                    MessageBox.Show("No reset key available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


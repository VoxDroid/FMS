using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SPAAT.SubPages
{
    public partial class SecurityQuestions : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        private List<string> allQuestions;
        private string initialOption = "-- Select Security Question --";
        private bool isUpdating = false;

        public SecurityQuestions()
        {
            InitializeComponent();

            allQuestions = new List<string>
            {
                "What is the name of your first pet?",
                "In which city were you born?",
                "What is your mother's maiden name?",
                "What is the name of your favorite childhood teacher?",
                "What is the model of your first car?",
                "What is the name of your favorite book?",
                "What is the name of your best friend from childhood?",
                "What is the make of your first computer or laptop?",
                "What was the street you lived on in third grade?",
                "In which year did you graduate from high school?",
                "What is your favorite movie?",
                "What is the name of the street you grew up on?",
                "What is your favorite color?",
                "In which country would you like to retire?",
                "What is the name of the company where you had your first job?",
                "What is your favorite sports team?",
                "What is the middle name of your oldest sibling?",
                "What is the name of the elementary school you attended?",
                "What is the last name of your favorite high school teacher?",
                "What is your favorite holiday destination?"
            };

            InitializeComboBox(sq1);
            InitializeComboBox(sq2);
            InitializeComboBox(sq3);

            sq1.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq1, sq2, sq3);
            sq2.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq2, sq1, sq3);
            sq3.SelectedIndexChanged += (s, e) => UpdateComboBoxItems(sq3, sq1, sq2);
        }

        private void InitializeComboBox(Guna2ComboBox comboBox)
        {
            if (comboBox.Items.Count == 0)
            {
                comboBox.Items.Add(initialOption);
                comboBox.Items.AddRange(allQuestions.ToArray());
                comboBox.SelectedItem = initialOption;
            }
        }

        private void UpdateComboBoxItems(Guna2ComboBox currentComboBox, params Guna2ComboBox[] dependentComboBoxes)
        {
            if (isUpdating) return;

            isUpdating = true;

            foreach (Guna2ComboBox dependentComboBox in dependentComboBoxes)
            {
                if (dependentComboBox != currentComboBox)
                {
                    string selectedInCurrent = currentComboBox.SelectedItem?.ToString();
                    string selectedInDependent = dependentComboBox.SelectedItem?.ToString();

                    dependentComboBox.Items.Clear();
                    InitializeComboBox(dependentComboBox);

                    if (selectedInCurrent != null)
                    {
                        foreach (var comboBox in dependentComboBoxes)
                        {
                            if (comboBox != currentComboBox)
                            {
                                comboBox.Items.Remove(selectedInCurrent);
                            }
                        }
                    }

                    if (selectedInDependent != null && dependentComboBox.Items.Contains(selectedInDependent))
                    {
                        dependentComboBox.SelectedItem = selectedInDependent;
                    }
                    else
                    {
                        dependentComboBox.SelectedItem = initialOption;
                    }
                }
            }

            isUpdating = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as Main;

            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 9;
                }
            }
        }

        private void sq3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sq3a.Text = string.Empty;
        }

        private void sq2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sq2a.Text = string.Empty;
        }

        private void sq1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sq1a.Text = string.Empty;
        }

        private void sq1_TextUpdate(object sender, EventArgs e)
        {
            sq1a.Text = string.Empty;
        }

        private void sq2_TextUpdate(object sender, EventArgs e)
        {
            sq2a.Text = string.Empty;
        }

        private void sq3_TextUpdate(object sender, EventArgs e)
        {
            sq3a.Text = string.Empty;
        }

        private void set_Click(object sender, EventArgs e)
        {
            securityStatusLabel.ForeColor = System.Drawing.Color.DarkGreen;
            securityStatusLabel.Enabled = true;
            securityStatusLabel.Visible = true;

            string sq1Value = sq1.SelectedItem?.ToString();
            string sq2Value = sq2.SelectedItem?.ToString();
            string sq3Value = sq3.SelectedItem?.ToString();

            string sq1aValue = sq1a.Text.Trim();
            string sq2aValue = sq2a.Text.Trim();
            string sq3aValue = sq3a.Text.Trim();

            if (string.IsNullOrWhiteSpace(sq1Value) || string.IsNullOrWhiteSpace(sq2Value) || string.IsNullOrWhiteSpace(sq3Value) ||
                string.IsNullOrWhiteSpace(sq1aValue) || string.IsNullOrWhiteSpace(sq2aValue) || string.IsNullOrWhiteSpace(sq3aValue))
            {
                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                securityStatusLabel.Text = "Please fill in all security questions and answers.";
                return;
            }

            if (sq1Value == "-- Select Security Question --" || sq2Value == "-- Select Security Question --" || sq3Value == "-- Select Security Question --")
            {
                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                securityStatusLabel.Text = "Please select security questions.";
                return;
            }


            string sqlSelect = "SELECT * FROM securityquestions WHERE sqs_id = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    List<string> existingValues = new List<string>();

                    using (MySqlCommand selectCommand = new MySqlCommand(sqlSelect, connection))
                    {
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int i = 1; i <= 6; i++)
                                {
                                    existingValues.Add(reader.IsDBNull(i) ? string.Empty : reader.GetString(i));
                                }
                            }
                        }
                    }

                    if (existingValues.Count == 6)
                    {
                        string sqlUpdate = "UPDATE securityquestions SET sq1 = @sq1, sq2 = @sq2, sq3 = @sq3, " +
                                           "sq1a = @sq1a, sq2a = @sq2a, sq3a = @sq3a WHERE sqs_id = 1";

                        using (MySqlCommand updateCommand = new MySqlCommand(sqlUpdate, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@sq1", sq1Value);
                            updateCommand.Parameters.AddWithValue("@sq2", sq2Value);
                            updateCommand.Parameters.AddWithValue("@sq3", sq3Value);
                            updateCommand.Parameters.AddWithValue("@sq1a", sq1aValue);
                            updateCommand.Parameters.AddWithValue("@sq2a", sq2aValue);
                            updateCommand.Parameters.AddWithValue("@sq3a", sq3aValue);

                            int rowsUpdated = updateCommand.ExecuteNonQuery();

                            if (rowsUpdated > 0)
                            {
                                securityStatusLabel.Text = "Security questions updated successfully.";
                            }
                            else
                            {
                                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                                securityStatusLabel.Text = "Failed to update security questions.";
                            }
                        }
                    }
                    else
                    {
                        string sqlInsert = "INSERT INTO securityquestions (sqs_id, sq1, sq2, sq3, sq1a, sq2a, sq3a) " +
                                           "VALUES (1, @sq1, @sq2, @sq3, @sq1a, @sq2a, @sq3a)";

                        using (MySqlCommand insertCommand = new MySqlCommand(sqlInsert, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@sq1", sq1Value);
                            insertCommand.Parameters.AddWithValue("@sq2", sq2Value);
                            insertCommand.Parameters.AddWithValue("@sq3", sq3Value);
                            insertCommand.Parameters.AddWithValue("@sq1a", sq1aValue);
                            insertCommand.Parameters.AddWithValue("@sq2a", sq2aValue);
                            insertCommand.Parameters.AddWithValue("@sq3a", sq3aValue);

                            int rowsInserted = insertCommand.ExecuteNonQuery();

                            if (rowsInserted > 0)
                            {
                                securityStatusLabel.Text = "Security questions inserted successfully.";
                            }
                            else
                            {
                                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                                securityStatusLabel.Text = "Failed to insert security questions.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SecurityQuestions_Enter(object sender, EventArgs e)
        {
            securityStatusLabel.Enabled = false;
            securityStatusLabel.Visible = false;
            sq1.Text = string.Empty; sq2.Text = string.Empty; sq3.Text = string.Empty;
        }

        private void view_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM securityquestions WHERE sqs_id = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand selectCommand = new MySqlCommand(sqlSelect, connection))
                    {
                        using (MySqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string sq1Value = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                                string sq2Value = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                                string sq3Value = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                                string sq1aValue = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                                string sq2aValue = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                                string sq3aValue = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);

                                string message = $"Warning: These are your security questions and answers, remember and keep them in case you lost your access to the system.\n" +
                                                 $"\nQuestion 1: {sq1Value}\nAnswer 1: {sq1aValue}\n" +
                                                 $"\nQuestion 2: {sq2Value}\nAnswer 2: {sq2aValue}\n" +
                                                 $"\nQuestion 3: {sq3Value}\nAnswer 3: {sq3aValue}";

                                MessageBox.Show(message, "Security Questions and Answers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MessageBox.Show("No security questions found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void securityStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
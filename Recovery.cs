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

namespace SPAAT
{
    public partial class Recovery : Form
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public Recovery()
        {
            InitializeComponent();
            DisplaySecurityQuestions();
        }

        private void DisplaySecurityQuestions()
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
                                string sq1Question = reader.IsDBNull(reader.GetOrdinal("sq1")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq1"));
                                string sq2Question = reader.IsDBNull(reader.GetOrdinal("sq2")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq2"));
                                string sq3Question = reader.IsDBNull(reader.GetOrdinal("sq3")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq3"));

                                sq1.Text = "Question 1: " + sq1Question;
                                sq2.Text = "Question 2: " + sq2Question;
                                sq3.Text = "Question 3: " + sq3Question;
                            }
                            else
                            {
                                List<string> defaultQuestions = new List<string>
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

                                sq1.Text = "Question 1: " + defaultQuestions[0];
                                sq2.Text = "Question 2: " + defaultQuestions[1];
                                sq3.Text = "Question 3: " + defaultQuestions[2];
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

        private void set_Click(object sender, EventArgs e)
        {
            securityStatusLabel.ForeColor = System.Drawing.Color.DarkGreen;
            securityStatusLabel.Enabled = true;
            securityStatusLabel.Visible = true;

            string sq1Answer = sq1a.Text.Trim();
            string sq2Answer = sq2a.Text.Trim();
            string sq3Answer = sq3a.Text.Trim();

            if (string.IsNullOrWhiteSpace(sq1Answer) || string.IsNullOrWhiteSpace(sq2Answer) || string.IsNullOrWhiteSpace(sq3Answer))
            {
                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                securityStatusLabel.Text = "Please fill in all the answers to the security questions.";
                return;
            }

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
                                string storedSq1Answer = reader.IsDBNull(reader.GetOrdinal("sq1a")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq1a"));
                                string storedSq2Answer = reader.IsDBNull(reader.GetOrdinal("sq2a")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq2a"));
                                string storedSq3Answer = reader.IsDBNull(reader.GetOrdinal("sq3a")) ? string.Empty : reader.GetString(reader.GetOrdinal("sq3a"));

                                bool isCorrect = CheckAnswers(sq1Answer, sq2Answer, sq3Answer, storedSq1Answer, storedSq2Answer, storedSq3Answer);

                                if (isCorrect)
                                {
                                    string adminUsername;
                                    string adminPassword;
                                    reader.Close();
                                    string sqlRetrieveAdmin = "SELECT username, password FROM users WHERE user_id = 1";

                                    using (MySqlCommand retrieveAdminCommand = new MySqlCommand(sqlRetrieveAdmin, connection))
                                    {
                                        using (MySqlDataReader adminReader = retrieveAdminCommand.ExecuteReader())
                                        {
                                            if (adminReader.Read())
                                            {
                                                adminUsername = adminReader.IsDBNull(adminReader.GetOrdinal("username")) ? string.Empty : adminReader.GetString(adminReader.GetOrdinal("username"));
                                                adminPassword = adminReader.IsDBNull(adminReader.GetOrdinal("password")) ? string.Empty : adminReader.GetString(adminReader.GetOrdinal("password"));
                                            }
                                            else
                                            {
                                                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                                                securityStatusLabel.Text = "Failed to retrieve admin credentials.";
                                                return;
                                            }
                                        }
                                    }

                                    securityStatusLabel.ForeColor = System.Drawing.Color.DarkGreen;
                                    securityStatusLabel.Text = "Access Granted.";

                                    var rec = MessageBox.Show($"Your access has been recovered.\n\nAdmin Username: {adminUsername}\nAdmin Password: {adminPassword}\n\nDo you want to close the recovery page?", "Access Recovered.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (rec == DialogResult.Yes)
                                    {
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                                    securityStatusLabel.Text = "Incorrect answers. Please try again.";
                                }
                            }
                            else
                            {
                                securityStatusLabel.ForeColor = System.Drawing.Color.Maroon;
                                securityStatusLabel.Text = "Incorrect answers. Please try again.";
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

        private bool CheckAnswers(string inputSq1, string inputSq2, string inputSq3, string storedSq1, string storedSq2, string storedSq3)
        {
            return inputSq1.Equals(storedSq1, StringComparison.OrdinalIgnoreCase) &&
                   inputSq2.Equals(storedSq2, StringComparison.OrdinalIgnoreCase) &&
                   inputSq3.Equals(storedSq3, StringComparison.OrdinalIgnoreCase);
        }
    }
}

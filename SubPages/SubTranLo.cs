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
using Guna.UI2.WinForms;

namespace SPAAT.SubPages
{
    public partial class SubTranLo : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public SubTranLo()
        {
            InitializeComponent();
            LoadRecentCategories();
        }

        public Label GetPagesControl()
        {
            return budgetstatuslabel;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            budgetstatuslabel.Enabled = false;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.ForeColor = Color.DarkGreen;
            var mainForm = this.ParentForm as Main;


            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 4;
                }
            }
            LoadRecentCategories();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            nametb.Text = string.Empty;
            categorytb.Text = string.Empty;
            alloctb.Text = string.Empty;
            remtb.Text = string.Empty;
            budgetstatuslabel.ForeColor = Color.DarkGreen;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.Enabled = false;
            LoadRecentCategories();
        }

        private void createbudget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text) || string.IsNullOrWhiteSpace(categorytb.Text) ||
                string.IsNullOrWhiteSpace(alloctb.Text) || string.IsNullOrWhiteSpace(remtb.Text))
            {
                budgetstatuslabel.ForeColor = Color.Maroon;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Text = "Please fill in all the fields.";
            }
            else
            {
                string name = nametb.Text.Trim();
                string description = categorytb.Text.Trim();
                string category = alloctb.Text.Trim();
                double amount = Convert.ToDouble(remtb.Text);

                if (IsRecordExists(name, category, amount))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Text = "Record with the same name, category, and amount already exists.";
                    return;
                }

                DateTime currentDate = DateTime.Now;

                string sqlInsert = "INSERT INTO tranlo (name, category, description, amount, date) " +
                                   "VALUES (@name, @category, @description, @amount, @date)";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connet))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlInsert, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@category", category);
                            command.Parameters.AddWithValue("@description", description);
                            command.Parameters.AddWithValue("@amount", amount);
                            command.Parameters.AddWithValue("@date", currentDate);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                budgetstatuslabel.Enabled = true;
                                budgetstatuslabel.Visible = true;
                                budgetstatuslabel.ForeColor = Color.DarkGreen;
                                budgetstatuslabel.Text = "Record inserted successfully.";
                                nametb.Clear();
                                categorytb.Clear();
                                alloctb.Clear();
                                remtb.Clear();

                                LoadRecentCategories();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert record.");

                                LoadRecentCategories();
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

        private bool IsRecordExists(string name, string category, double amount)
        {
            string sqlCheck = "SELECT COUNT(*) FROM tranlo WHERE name = @name AND category = @category AND amount = @amount";

            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(sqlCheck, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@category", category);
                    command.Parameters.AddWithValue("@amount", amount);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void remtb_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(remtb.Text, out int typedAmount))
            {
                if (typedAmount == 0)
                {
                    remtb.Text = "1";
                    remtb.SelectionStart = remtb.Text.Length;
                }
            }
        }

        private void remtb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && remtb.Text.Length == 1)
            {
                remtb.Text = "";
            }
        }

        private void recentstudentscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recentstudentscb.SelectedIndex == 0)
            {
                alloctb.Text = string.Empty;
            }
            else
            {
                alloctb.Text = recentstudentscb.Text;
            }
        }

        private void LoadRecentCategories()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT DISTINCT category FROM tranlo ORDER BY tl_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            recentstudentscb.DataSource = null;
                            recentstudentscb.Items.Clear();

                            DataRow initialRow = dataTable.NewRow();
                            initialRow["category"] = "-- Recent --";
                            dataTable.Rows.InsertAt(initialRow, 0);

                            recentstudentscb.DataSource = dataTable;
                            recentstudentscb.DisplayMember = "category";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void recentstudentscb_Click(object sender, EventArgs e)
        {
            LoadRecentCategories();
        }

        private void alloctb_TextChanged(object sender, EventArgs e)
        {
            alloctb.Text = alloctb.Text.ToUpper();

            alloctb.SelectionStart = alloctb.Text.Length;
            alloctb.SelectionLength = 0;
        }

        private void alloctb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
    


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
using System.Runtime.InteropServices;

namespace SPAAT.SubPages
{
    public partial class SubBudMan : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public SubBudMan()
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
                    pagesControl.SelectedIndex = 1;
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
                string name = nametb.Text;
                string category = categorytb.Text;
                double budget = Convert.ToDouble(alloctb.Text);
                double remaining = Convert.ToDouble(remtb.Text);

                string sqlInsert = "INSERT INTO budman (name, category, allocation, remaining) VALUES (@name, @category, @allocation, @remaining)";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connet))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(sqlInsert, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@category", category);
                            command.Parameters.AddWithValue("@allocation", budget);
                            command.Parameters.AddWithValue("@remaining", remaining);

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

        private void NumbersOnly2Alloc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            string newText = remtb.Text + e.KeyChar;

            if (!string.IsNullOrEmpty(newText) && decimal.TryParse(newText, out decimal typedAmount))
            {
                decimal chargeAmount = Convert.ToDecimal(alloctb.Text);

                if (typedAmount < 1 && typedAmount == 0)
                {
                    e.Handled = true;
                    remtb.Text = "1";
                }
                else if (typedAmount > chargeAmount)
                {
                    e.Handled = true;
                    remtb.Text = chargeAmount.ToString();
                }
            }
        }

        private void SubBudMan_Load(object sender, EventArgs e)
        {

        }

        private void budgetstatuslabel_Click(object sender, EventArgs e)
        {

        }

        private void alloctb_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(alloctb.Text, out int typedAmount))
            {
                if (typedAmount == 0)
                {
                    alloctb.Text = "1";
                    alloctb.SelectionStart = alloctb.Text.Length;
                }
            }
            remtb.Text = string.Empty;
            remtb.Enabled = !string.IsNullOrWhiteSpace(alloctb.Text);
        }

        private void alloctb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && alloctb.Text.Length == 1)
            {
                alloctb.Text = "";
            }
        }

        private void remtb_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(remtb.Text, out int typedAmount))
            {
                if (typedAmount == 0)
                {
                    remtb.Text = "1";
                    remtb.SelectionStart = alloctb.Text.Length;
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
                categorytb.Text = string.Empty;
            }
            else
            {
                categorytb.Text = recentstudentscb.Text;
            }
        }

        private void LoadRecentCategories()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT DISTINCT category FROM budman ORDER BY bm_id DESC";
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

        private void categorytb_TextChanged(object sender, EventArgs e)
        {
            categorytb.Text = categorytb.Text.ToUpper();

            categorytb.SelectionStart = categorytb.Text.Length;
            categorytb.SelectionLength = 0;
        }

        private void categorytb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}

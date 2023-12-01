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
    public partial class SubBudMan : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public SubBudMan()
        {
            InitializeComponent();
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

        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SubBudMan_Load(object sender, EventArgs e)
        {

        }

        private void budgetstatuslabel_Click(object sender, EventArgs e)
        {

        }
    }
}

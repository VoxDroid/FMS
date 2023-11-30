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
using DocumentFormat.OpenXml.Wordprocessing;

namespace SPAAT.SubPages
{
    public partial class SubStudFil : UserControl
    {
        string connet = "Server=localhost;Database=fms;Username=root;Password=;";
        public SubStudFil()
        {
            InitializeComponent();
            LoadStudentNames();
        }

        private void LoadStudentNames()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT name FROM studname ORDER BY sn_id DESC";
                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            recentstudentscb.DataSource = null;
                            recentstudentscb.Items.Clear();

                            DataRow initialRow = dataTable.NewRow();
                            initialRow["name"] = "-- Recent Students --";
                            dataTable.Rows.InsertAt(initialRow, 0);

                            recentstudentscb.DataSource = dataTable;
                            recentstudentscb.DisplayMember = "name";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            budgetstatuslabel.Enabled = false;
            budgetstatuslabel.Visible = false; 
            budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            nametb.Text = string.Empty;
            amountptb.Text = string.Empty;
            chargetb.Text = string.Empty;
            paymentstatuslb.Text = "Payment Status: N/A";
            LoadStudentNames();
            var mainForm = this.ParentForm as Main;


            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 10;
                }
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            nametb.Text = string.Empty;
            amountptb.Text = string.Empty;
            chargetb.Text = string.Empty;
            paymentstatuslb.Text = "Payment Status: N/A";
            budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.Enabled = false;
            LoadStudentNames();
        }

        private void createbudget_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nametb.Text) || string.IsNullOrWhiteSpace(chargetb.Text) ||
                string.IsNullOrWhiteSpace(amountptb.Text))
            {
                budgetstatuslabel.ForeColor = System.Drawing.Color.Maroon;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Text = "Please fill in all the fields.";
            }
            else
            {
                try
                {
                    string name = nametb.Text;
                    string charge = chargetb.Text;
                    string amountpaid = amountptb.Text;

                    DateTime currentDate = DateTime.Now;

                    using (MySqlConnection connection = new MySqlConnection(connet))
                    {
                        connection.Open();

                        string sqlCheckName = "SELECT sn_id FROM studname WHERE name = @name";
                        using (MySqlCommand commandCheckName = new MySqlCommand(sqlCheckName, connection))
                        {
                            commandCheckName.Parameters.AddWithValue("@name", name);

                            object existingSnId = commandCheckName.ExecuteScalar();

                            int snId;
                            if (existingSnId != null)
                            {
                                snId = Convert.ToInt32(existingSnId);
                            }
                            else
                            {
                                string sqlInsertName = "INSERT INTO studname (name) VALUES (@name); SELECT LAST_INSERT_ID();";
                                using (MySqlCommand commandInsertName = new MySqlCommand(sqlInsertName, connection))
                                {
                                    commandInsertName.Parameters.AddWithValue("@name", name);
                                    snId = Convert.ToInt32(commandInsertName.ExecuteScalar());
                                }
                            }

                            string sqlInsertFil = "INSERT INTO studfil (sn_id, name, amountpaid, charge, paymentdate, paymentstatus) " +
                                                  "VALUES (@snId, @name, @amountpaid, @charge, @paymentdate, @paymentstatus)";

                            using (MySqlCommand commandFil = new MySqlCommand(sqlInsertFil, connection))
                            {
                                commandFil.Parameters.AddWithValue("@snId", snId);
                                commandFil.Parameters.AddWithValue("@name", name);
                                commandFil.Parameters.AddWithValue("@amountpaid", amountpaid);
                                commandFil.Parameters.AddWithValue("@charge", charge);
                                commandFil.Parameters.AddWithValue("@paymentdate", currentDate.AddMonths(1).ToString("yyyy-MM-dd"));
                                commandFil.Parameters.AddWithValue("@paymentstatus", Convert.ToDecimal(charge) == Convert.ToDecimal(amountpaid) ? "Paid" : "Partial");

                                int rowsAffectedFil = commandFil.ExecuteNonQuery();

                                string sqlGetDebt = "SELECT debtamount FROM studdeb WHERE sn_id = @snId";
                                using (MySqlCommand commandGetDebt = new MySqlCommand(sqlGetDebt, connection))
                                {
                                    commandGetDebt.Parameters.AddWithValue("@snId", snId);
                                    object existingDebt = commandGetDebt.ExecuteScalar();

                                    decimal currentDebt = existingDebt != null ? Convert.ToDecimal(existingDebt) : 0;

                                    decimal newDebt = currentDebt + (Convert.ToDecimal(charge) - Convert.ToDecimal(amountpaid));
                                    newDebt = Math.Max(newDebt, 0);

                                    string sqlInsertOrUpdateDebt = "INSERT INTO studdeb (sn_id, name, hasdebt, debtamount) " +
                                                                   "VALUES (@snId, @name, @hasdebt, @newDebt) " +
                                                                   "ON DUPLICATE KEY UPDATE debtamount = @newDebt";

                                    using (MySqlCommand commandDebt = new MySqlCommand(sqlInsertOrUpdateDebt, connection))
                                    {
                                        bool hasDebt = newDebt > 0;

                                        commandDebt.Parameters.AddWithValue("@snId", snId);
                                        commandDebt.Parameters.AddWithValue("@name", name);
                                        commandDebt.Parameters.AddWithValue("@hasdebt", hasDebt);
                                        commandDebt.Parameters.AddWithValue("@newDebt", newDebt);

                                        int rowsAffectedDebt = commandDebt.ExecuteNonQuery();

                                        if (rowsAffectedFil > 0 && rowsAffectedDebt >= 0)
                                        {
                                            budgetstatuslabel.Enabled = true;
                                            budgetstatuslabel.Visible = true;
                                            budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
                                            budgetstatuslabel.Text = "Record inserted successfully.";
                                            LoadStudentNames();
                                            nametb.Clear();
                                            amountptb.Clear();
                                            chargetb.Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to insert or update records.");
                                        }
                                    }
                                }
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

        private void UpdatePaymentStatus()
        {
            if (!string.IsNullOrEmpty(chargetb.Text) && !string.IsNullOrEmpty(amountptb.Text))
            {
                decimal chargeAmount = Convert.ToDecimal(chargetb.Text);
                decimal paidAmount = Convert.ToDecimal(amountptb.Text);

                if (paidAmount == chargeAmount)
                {
                    paymentstatuslb.Text = "Payment Status: Paid";
                }
                else if (paidAmount < chargeAmount)
                {
                    paymentstatuslb.Text = "Payment Status: Partial";
                }
                else
                {
                    paymentstatuslb.Text = "Payment Status: Invalid";
                }
            }
            else
            {
                paymentstatuslb.Text = "Payment Status: N/A";
            }
        }

        private void autofillpaid_Click(object sender, EventArgs e)
        {
            amountptb.Text = chargetb.Text;
        }

        private void chargetb_TextChanged(object sender, EventArgs e)
        {
            amountptb.Enabled = !string.IsNullOrWhiteSpace(chargetb.Text);
            autofillpaid.Enabled = !string.IsNullOrWhiteSpace(chargetb.Text);
            UpdatePaymentStatus();
        }

        private void amountptb_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(chargetb.Text) && !string.IsNullOrWhiteSpace(amountptb.Text))
            {
                decimal chargeAmount = Convert.ToDecimal(chargetb.Text);
                decimal paidAmount = Convert.ToDecimal(amountptb.Text);

                if (paidAmount > chargeAmount)
                {
                    e.Cancel = true;
                    MessageBox.Show("Paid amount cannot be greater than the charge amount.");
                }
            }
        }



        private void amountptb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            string newText = amountptb.Text + e.KeyChar;

            if (!string.IsNullOrEmpty(newText) && decimal.TryParse(newText, out decimal typedAmount))
            {
                decimal chargeAmount = Convert.ToDecimal(chargetb.Text);

                if (typedAmount < 1 && typedAmount == 0)
                {
                    e.Handled = true;
                    amountptb.Text = "1";
                }
                else if (typedAmount > chargeAmount)
                {
                    e.Handled = true;
                    amountptb.Text = chargeAmount.ToString();
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

        private void amountptb_TextChanged(object sender, EventArgs e)
        {
            UpdatePaymentStatus();
        }
    }
}

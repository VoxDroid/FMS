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

namespace SPAAT.SubPages
{
    public partial class ModStudFil : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public ModStudFil()
        {
            InitializeComponent();
            PopulateDataGridView();
        }


        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT pm_id, sn_id, name, charge, amountpaid, paymentdate, paymentstatus FROM studfil;";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        budmangrid.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid.Rows.Add();
                            budmangrid.Rows[rowIndex].Cells["pm_id"].Value = row["pm_id"];
                            budmangrid.Rows[rowIndex].Cells["sn_id"].Value = row["sn_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["charge"].Value = row["charge"];
                            budmangrid.Rows[rowIndex].Cells["amountpaid"].Value = row["amountpaid"];
                            budmangrid.Rows[rowIndex].Cells["paymentdate"].Value = row["paymentdate"];
                            budmangrid.Rows[rowIndex].Cells["status"].Value = row["paymentstatus"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FilterDataGridView(string searchQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM studfil " +
                              "WHERE name LIKE @searchQuery " +
                              "   OR amountpaid LIKE @searchQuery " +
                              "   OR paymentdate LIKE @searchQuery" +
                              "   OR paymentstatus LIKE @searchQuery" +
                              "   OR charge LIKE @searchQuery";

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
                            budmangrid.Rows[rowIndex].Cells["pm_id"].Value = row["pm_id"];
                            budmangrid.Rows[rowIndex].Cells["sn_id"].Value = row["sn_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["charge"].Value = row["charge"];
                            budmangrid.Rows[rowIndex].Cells["amountpaid"].Value = row["amountpaid"];
                            budmangrid.Rows[rowIndex].Cells["paymentdate"].Value = row["paymentdate"];
                            budmangrid.Rows[rowIndex].Cells["status"].Value = row["paymentstatus"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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


        private void budmangrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string yourAllocationColumnName = "charge";
            string yourRemainingColumnName = "amountpaid";

            int yourAllocationColumnIndex = budmangrid.Columns[yourAllocationColumnName].Index;
            int yourRemainingColumnIndex = budmangrid.Columns[yourRemainingColumnName].Index;

            if (e.RowIndex >= 0 && (e.ColumnIndex == yourAllocationColumnIndex || e.ColumnIndex == yourRemainingColumnIndex))
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    decimal cellValue;
                    if (decimal.TryParse(e.Value.ToString(), out cellValue))
                    {
                        e.Value = string.Format("₱{0:N0}", cellValue);
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = "Invalid Value";
                        e.FormattingApplied = true;
                    }
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

        private void recompensebutton_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            searchtextbox.Text = string.Empty;
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            FilterDataGridView(searchQuery);
        }

        private void chargetb_TextChanged(object sender, EventArgs e)
        {
            amountptb.Enabled = !string.IsNullOrWhiteSpace(chargetb.Text);
            autofillpaid.Enabled = !string.IsNullOrWhiteSpace(chargetb.Text);
            UpdatePaymentStatus();
        }

        private void autofillpaid_Click(object sender, EventArgs e)
        {
            amountptb.Text = chargetb.Text;
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


        private void modify_Click(object sender, EventArgs e)
        {
            amountptb.Text = string.Empty;
            chargetb.Text = string.Empty;
            paymentstatuslb.Text = "Payment Status: N/A";
            budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.Enabled = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            budgetstatuslabel.Enabled = false;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.ForeColor = System.Drawing.Color.DarkGreen;
            amountptb.Text = string.Empty;
            chargetb.Text = string.Empty;
            paymentstatuslb.Text = "Payment Status: N/A";
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

        private void modifybutton_Click(object sender, EventArgs e)
        {
            if (budmangrid.SelectedRows.Count == 0)
            {
                budgetstatuslabel.ForeColor = Color.Maroon;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Text = "Please select a row to update.";
                return;
            }

            try
            {
                DataGridViewRow selectedRow = budmangrid.SelectedRows[0];
                int snId = Convert.ToInt32(selectedRow.Cells["sn_id"].Value);
                string name = selectedRow.Cells["name"].Value.ToString();
                string originalCharge = selectedRow.Cells["charge"].Value.ToString();
                string originalAmountPaid = selectedRow.Cells["amountpaid"].Value.ToString();

                string newCharge = chargetb.Text.Trim();
                string newAmountPaid = amountptb.Text.Trim();

                if (string.IsNullOrWhiteSpace(newCharge) || string.IsNullOrWhiteSpace(newAmountPaid))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Text = "Please fill in all the fields.";
                    return;
                }

                DateTime currentDate = DateTime.Now;

                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string sqlUpdateFil = "UPDATE studfil " +
                                              "SET charge = @charge, amountpaid = @amountpaid " +
                                              "WHERE sn_id = @snId";

                        using (MySqlCommand commandUpdateFil = new MySqlCommand(sqlUpdateFil, connection))
                        {
                            commandUpdateFil.Parameters.AddWithValue("@snId", snId);
                            commandUpdateFil.Parameters.AddWithValue("@charge", newCharge);
                            commandUpdateFil.Parameters.AddWithValue("@amountpaid", newAmountPaid);

                            int rowsAffectedFil = commandUpdateFil.ExecuteNonQuery();

                            if (rowsAffectedFil > 0)
                            {
                                UpdateDebtStatusAndAmount(connection, snId, name, newCharge, newAmountPaid, originalCharge, originalAmountPaid);

                                budgetstatuslabel.ForeColor = Color.DarkGreen;
                                budgetstatuslabel.Visible = true;
                                budgetstatuslabel.Enabled = true;
                                budgetstatuslabel.Text = "Record updated successfully.";
                                amountptb.Clear();
                                chargetb.Clear();
                            }
                            else
                            {
                                budgetstatuslabel.ForeColor = Color.Maroon;
                                budgetstatuslabel.Visible = true;
                                budgetstatuslabel.Enabled = true;
                                budgetstatuslabel.Text = "Failed to update record.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateDebtStatusAndAmount(MySqlConnection connection, int snId, string name, string newCharge, string newAmountPaid, string existingCharge, string existingAmountPaid)
        {
            try
            {
                string sqlGetDebt = "SELECT debtamount FROM studdeb WHERE sn_id = @snId";

                using (MySqlConnection debtConnection = new MySqlConnection(connection.ConnectionString))
                {
                    debtConnection.Open();

                    using (MySqlCommand commandGetDebt = new MySqlCommand(sqlGetDebt, debtConnection))
                    {
                        commandGetDebt.Parameters.AddWithValue("@snId", snId);
                        object existingDebt = commandGetDebt.ExecuteScalar();

                        decimal currentDebt = existingDebt != null ? Convert.ToDecimal(existingDebt) : 0;

                        currentDebt -= Convert.ToDecimal(existingCharge) - Convert.ToDecimal(existingAmountPaid);

                        decimal newDebt = currentDebt + (Convert.ToDecimal(newCharge) - Convert.ToDecimal(newAmountPaid));

                        newDebt = Math.Max(newDebt, 0);

                        bool hasDebt = newDebt > 0;

                        string paymentStatus = Convert.ToDecimal(newCharge) == Convert.ToDecimal(newAmountPaid) ? "Paid" : "Partial";

                        string sqlUpdateDebt = "UPDATE studdeb SET hasdebt = @hasdebt, debtamount = @newDebt WHERE sn_id = @snId";

                        using (MySqlCommand commandUpdateDebt = new MySqlCommand(sqlUpdateDebt, debtConnection))
                        {
                            commandUpdateDebt.Parameters.AddWithValue("@snId", snId);
                            commandUpdateDebt.Parameters.AddWithValue("@hasdebt", hasDebt);
                            commandUpdateDebt.Parameters.AddWithValue("@newDebt", newDebt);

                            int rowsAffectedUpdateDebt = commandUpdateDebt.ExecuteNonQuery();
                        }

                        string sqlUpdatePaymentStatus = "UPDATE studfil SET paymentstatus = @paymentstatus WHERE sn_id = @snId";

                        using (MySqlCommand commandUpdatePaymentStatus = new MySqlCommand(sqlUpdatePaymentStatus, debtConnection))
                        {
                            commandUpdatePaymentStatus.Parameters.AddWithValue("@snId", snId);
                            commandUpdatePaymentStatus.Parameters.AddWithValue("@paymentstatus", paymentStatus);

                            int rowsAffectedUpdatePaymentStatus = commandUpdatePaymentStatus.ExecuteNonQuery();
                        }
                    }
                }
            }
            finally
            {
                
            }
        }
    }
}

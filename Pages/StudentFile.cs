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
using Microsoft.VisualBasic;

namespace SPAAT.Pages
{
    public partial class StudentFile : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public StudentFile()
        {
            InitializeComponent();
            PopulateDataGridView();
            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
        }

        private void CalculateAndDisplayTotalCharge2()
        {
            int columnIndex = 1;
            decimal sum = 0;

            if (budmangrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in budmangrid.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && decimal.TryParse(row.Cells[columnIndex].Value.ToString(), out decimal cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            else
            {
                sum = -1;
            }

            if (sum == -1)
            {
                TFC2.Text = "Total Charge Amount: N/A";
            }
            else
            {
                TFC2.Text = $"Total Charge Amount: ₱{sum:n0}";
            }
        }

        private void CalculateAndDisplayTotalCharge()
        {
            int columnIndex = 2;
            decimal sum = 0;

            if (budmangrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in budmangrid.Rows)
                {
                    if (row.Cells[columnIndex].Value != null && decimal.TryParse(row.Cells[columnIndex].Value.ToString(), out decimal cellValue))
                    {
                        sum += cellValue;
                    }
                }
            }
            else
            {
                sum = -1;
            }

            if (sum == -1)
            {
                TFC.Text = "Total Funds Collected: N/A";
            }
            else
            {
                TFC.Text = $"Total Funds Collected: ₱{sum:n0}";
            }
        }

        private void createbudget_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as Main;

            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 11;
                }
            }

            var SBM = this.Parent.Controls["SubBudMan"] as SubBudMan;

            if (SBM != null)
            {
                Label pagesControl = SBM.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.Text = string.Empty;
                }
            }
        }

        private void modify_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as Main;

            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 12;
                }
            }
        }


        private void debts_Click(object sender, EventArgs e)
        {
            var mainForm = this.ParentForm as Main;

            if (mainForm != null)
            {
                BunifuPages pagesControl = mainForm.GetPagesControl();

                if (pagesControl != null)
                {
                    pagesControl.SelectedIndex = 13;
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (budmangrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow = budmangrid.SelectedRows[0];

                int selectedId = Convert.ToInt32(selectedRow.Cells["pm_id"].Value);
                int snId = Convert.ToInt32(selectedRow.Cells["sn_id"].Value);
                string name = selectedRow.Cells["name"].Value.ToString();
                string charge = selectedRow.Cells["charge"].Value.ToString();
                string amountPaid = selectedRow.Cells["amountpaid"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (DeleteRecord(selectedId, snId, name, charge, amountPaid))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
        }

        private bool DeleteRecord(int selectedId, int snId, string name, string charge, string amountPaid)
        {
            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                try
                {
                    connection.Open();

                    string sqlCheckLastRecord = "SELECT COUNT(*) FROM studfil WHERE sn_id = @snId";

                    using (MySqlCommand commandCheckLastRecord = new MySqlCommand(sqlCheckLastRecord, connection))
                    {
                        commandCheckLastRecord.Parameters.AddWithValue("@snId", snId);

                        int recordCount = Convert.ToInt32(commandCheckLastRecord.ExecuteScalar());

                        bool studfilDeleted = false;

                        string sqlDeleteRecord = "DELETE FROM studfil WHERE pm_id = @selectedId";

                        using (MySqlCommand commandDeleteRecord = new MySqlCommand(sqlDeleteRecord, connection))
                        {
                            commandDeleteRecord.Parameters.AddWithValue("@selectedId", selectedId);

                            int rowsAffectedDeleteRecord = commandDeleteRecord.ExecuteNonQuery();

                            studfilDeleted = rowsAffectedDeleteRecord > 0;
                        }

                        if (studfilDeleted)
                        {
                            string sqlGetDebt = "SELECT debtamount FROM studdeb WHERE sn_id = @snId";

                            using (MySqlCommand commandGetDebt = new MySqlCommand(sqlGetDebt, connection))
                            {
                                commandGetDebt.Parameters.AddWithValue("@snId", snId);
                                object existingDebt = commandGetDebt.ExecuteScalar();

                                decimal currentDebt = existingDebt != null ? Convert.ToDecimal(existingDebt) : 0;

                                currentDebt -= Convert.ToDecimal(charge) - Convert.ToDecimal(amountPaid);

                                currentDebt = Math.Max(currentDebt, 0);

                                string sqlUpdateDebt = "UPDATE studdeb SET debtamount = @currentDebt WHERE sn_id = @snId";

                                using (MySqlCommand commandUpdateDebt = new MySqlCommand(sqlUpdateDebt, connection))
                                {
                                    commandUpdateDebt.Parameters.AddWithValue("@snId", snId);
                                    commandUpdateDebt.Parameters.AddWithValue("@currentDebt", currentDebt);

                                    int rowsAffectedUpdateDebt = commandUpdateDebt.ExecuteNonQuery();
                                }

                                bool hasDebt = currentDebt > 0;

                                string sqlUpdateHasDebt = "UPDATE studdeb SET hasdebt = @hasDebt WHERE sn_id = @snId";

                                using (MySqlCommand commandUpdateHasDebt = new MySqlCommand(sqlUpdateHasDebt, connection))
                                {
                                    commandUpdateHasDebt.Parameters.AddWithValue("@snId", snId);
                                    commandUpdateHasDebt.Parameters.AddWithValue("@hasDebt", hasDebt);

                                    int rowsAffectedUpdateHasDebt = commandUpdateHasDebt.ExecuteNonQuery();
                                }

                                if (recordCount == 1)
                                {
                                    string sqlDeleteDebtRecord = "DELETE FROM studdeb WHERE sn_id = @snId";

                                    using (MySqlCommand commandDeleteDebtRecord = new MySqlCommand(sqlDeleteDebtRecord, connection))
                                    {
                                        commandDeleteDebtRecord.Parameters.AddWithValue("@snId", snId);

                                        int rowsAffectedDeleteDebtRecord = commandDeleteDebtRecord.ExecuteNonQuery();
                                    }

                                    string sqlDeleteStudName = "DELETE FROM studname WHERE sn_id = @snId";

                                    using (MySqlCommand commandDeleteStudName = new MySqlCommand(sqlDeleteStudName, connection))
                                    {
                                        commandDeleteStudName.Parameters.AddWithValue("@snId", snId);

                                        int rowsAffectedDeleteStudName = commandDeleteStudName.ExecuteNonQuery();
                                    }
                                }
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
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
                UpdateTotalEntriesLabel();
                CalculateAndDisplayTotalCharge2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            UpdateTotalEntriesLabel();

            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
            searchtextbox.Text = string.Empty;
        }

        private void totalentrieslabel_Click(object sender, EventArgs e)
        {
            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge2();
        }

        private void UpdateTotalEntriesLabel()
        {
            totalentrieslabel.Text = $"Total Entries: {Environment.NewLine}{budmangrid.Rows.Count}";
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            FilterDataGridView(searchQuery);
            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
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
                        UpdateTotalEntriesLabel();
                        CalculateAndDisplayTotalCharge();
                        CalculateAndDisplayTotalCharge2();
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

        private void budmangrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

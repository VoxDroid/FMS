﻿using Bunifu.UI.WinForms;
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
using static Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexesCollectionEditor;

namespace SPAAT.Pages
{
    public partial class TransactionLogs : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        private bool isDescendingOrder = true;
        private string currentSearchQuery = string.Empty;

        public TransactionLogs()
        {
            InitializeComponent();
            PopulateDataGridView();
            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge();

            isDescendingOrder = !sbo.Checked;
        }

        private void CalculateAndDisplayTotalCharge()
        {
            int columnIndex = 5;
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
                TFC.Text = "Total Used Up Amount: N/A";
            }
            else
            {
                TFC.Text = $"Total Used Up Amount: \r\n₱{sum:n0}";
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
                    pagesControl.SelectedIndex = 5;
                }
            }

            var SBM = this.Parent.Controls["SubTranlo"] as SubTranLo;

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
                    pagesControl.SelectedIndex = 6;
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

                int selectedId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteRecord(selectedId);

                    PopulateDataGridView();
                    UpdateTotalEntriesLabel();
                    CalculateAndDisplayTotalCharge();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRecord(int tl_id)
        {
            string sqlDelete = "DELETE FROM tranlo WHERE tl_id = @tl_id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlDelete, connection))
                    {
                        command.Parameters.AddWithValue("@tl_id", tl_id);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sortOrder = isDescendingOrder ? "DESC" : "ASC";
                    string sqlQuery = $"SELECT tl_id, date, name, description, category, amount FROM tranlo WHERE category LIKE @searchQuery OR description LIKE @searchQuery OR amount LIKE @searchQuery OR name LIKE @searchQuery OR date LIKE @searchQuery ORDER BY tl_id {sortOrder};";

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
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["tl_id"];
                            budmangrid.Rows[rowIndex].Cells["date"].Value = row["date"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["desc"].Value = row["description"];
                            budmangrid.Rows[rowIndex].Cells["cat"].Value = row["category"];
                            budmangrid.Rows[rowIndex].Cells["amount"].Value = row["amount"];
                        }
                    }
                }
                UpdateTotalEntriesLabel();
                CalculateAndDisplayTotalCharge();
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
            searchtextbox.Text = string.Empty;
        }

        private void RefreshAll()
        {
            PopulateDataGridView();
            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge();
        }

        private void totalentrieslabel_Click(object sender, EventArgs e)
        {
            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge();
        }

        private void UpdateTotalEntriesLabel()
        {
            totalentrieslabel.Text = $"Total Entries: {Environment.NewLine} {budmangrid.Rows.Count}";
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            currentSearchQuery = searchQuery;

            FilterDataGridView(searchQuery);
            CalculateAndDisplayTotalCharge();
        }

        private void FilterDataGridView(string searchQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sortOrder = isDescendingOrder ? "DESC" : "ASC";
                    string sqlQuery = "SELECT * FROM tranlo " +
                              "WHERE category LIKE @searchQuery " +
                              "   OR description LIKE @searchQuery " +
                              "   OR amount LIKE @searchQuery" +
                              "   OR name LIKE @searchQuery" +
                              "   OR date LIKE @searchQuery" +
                                      $" ORDER BY tl_id {sortOrder};";

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
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["tl_id"];
                            budmangrid.Rows[rowIndex].Cells["date"].Value = row["date"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["desc"].Value = row["description"];
                            budmangrid.Rows[rowIndex].Cells["cat"].Value = row["category"];
                            budmangrid.Rows[rowIndex].Cells["amount"].Value = row["amount"];

                        }
                        UpdateTotalEntriesLabel();
                        CalculateAndDisplayTotalCharge();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void budmangrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string yourAllocationColumnName = "amount";

            int yourAllocationColumnIndex = budmangrid.Columns[yourAllocationColumnName].Index;

            if (e.RowIndex >= 0 && (e.ColumnIndex == yourAllocationColumnIndex))
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

            string yourDateColumnName = "date";

            int yourDateColumnIndex = budmangrid.Columns[yourDateColumnName].Index;

            if (e.RowIndex >= 0 && e.ColumnIndex == yourDateColumnIndex)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    DateTime cellValue;
                    if (DateTime.TryParse(e.Value.ToString(), out cellValue))
                    {
                        e.Value = cellValue.ToString("yyyy-MM-dd"); 
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = "Invalid Date";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void TransactionLogs_Enter(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void sbo_CheckedChanged(object sender, EventArgs e)
        {
            isDescendingOrder = !sbo.Checked;

            PopulateDataGridView(currentSearchQuery);
        }
    }
}


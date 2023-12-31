﻿using Bunifu.UI.WinForms;
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
using System.Data.SqlClient;

namespace SPAAT.SubPages
{
    public partial class ModTranLo : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        private bool isDescendingOrder = true;
        private string currentSearchQuery = string.Empty;

        public ModTranLo()
        {
            InitializeComponent();
            PopulateDataGridView();
            LoadRecentCategories();

            isDescendingOrder = !sbo.Checked;
        }


        private void PopulateDataGridView(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sortOrder = isDescendingOrder ? "DESC" : "ASC";
                    string sqlQuery = $"SELECT tl_id, date, name, description, category, amount FROM tranlo WHERE date LIKE @searchQuery OR name LIKE @searchQuery OR category LIKE @searchQuery OR description LIKE @searchQuery OR amount LIKE @searchQuery ORDER BY tl_id {sortOrder};";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        // Add parameters for the search query
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            nametb.Text = string.Empty;
            categorytb.Text = string.Empty;
            alloctb.Text = string.Empty;
            remtb.Text = string.Empty;
            searchtextbox.Text = string.Empty;
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
        private void clear_Click(object sender, EventArgs e)
        {
            nametb.Text = string.Empty;
            categorytb.Text = string.Empty;
            alloctb.Text = string.Empty;
            remtb.Text = string.Empty;
            searchtextbox.Text = string.Empty;
            budgetstatuslabel.ForeColor = Color.DarkGreen;
            budgetstatuslabel.Visible = false;
            budgetstatuslabel.Enabled = false;
            LoadRecentCategories();
        }

        private void modifydata_Click(object sender, EventArgs e)
        {
            if (budmangrid.SelectedRows.Count > 0)
            {
                string name = nametb.Text.Trim();
                string budget = categorytb.Text.Trim();
                string category = alloctb.Text.Trim();
                string remainingText = remtb.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(category) && string.IsNullOrWhiteSpace(budget) && string.IsNullOrWhiteSpace(remainingText))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Text = "Please fill in at least one field.";
                    return;
                }

                DataGridViewRow selectedRow = budmangrid.SelectedRows[0];
                int selectedRecordId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                string originalName = selectedRow.Cells["name"].Value.ToString();
                string originalCategory = selectedRow.Cells["cat"].Value.ToString();
                string originalBudget = selectedRow.Cells["desc"].Value.ToString();
                decimal originalRemaining = Convert.ToDecimal(selectedRow.Cells["amount"].Value);

                decimal remaining = string.IsNullOrWhiteSpace(remainingText) ? originalRemaining : Convert.ToDecimal(remainingText);

                if (IsRecordExists(name, category, remaining))
                {
                    budgetstatuslabel.ForeColor = Color.Maroon;
                    budgetstatuslabel.Enabled = true;
                    budgetstatuslabel.Visible = true;
                    budgetstatuslabel.Text = "Record with the same name, category, and amount already exists.";
                    return;
                }

                StringBuilder confirmationMessage = new StringBuilder("Are you sure you want to update this record with the following changes?\n\n");

                if (!string.IsNullOrWhiteSpace(name) && name != originalName)
                    confirmationMessage.AppendLine($"Name: {originalName} → {name}");

                if (!string.IsNullOrWhiteSpace(category) && category != originalCategory)
                    confirmationMessage.AppendLine($"Category: {originalCategory} → {category}");

                if (!string.IsNullOrWhiteSpace(budget) && budget != originalBudget)
                    confirmationMessage.AppendLine($"Description: {originalBudget} → {budget}");

                if (remaining != originalRemaining)
                    confirmationMessage.AppendLine($"Amount: {originalRemaining:C} → {remaining:C}");

                DialogResult result = MessageBox.Show(confirmationMessage.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sqlUpdate = "UPDATE tranlo SET name = @name, category = @category, description = @description, amount = @amount WHERE tl_id = @tl_id";

                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand(sqlUpdate, connection))
                            {
                                command.Parameters.AddWithValue("@name", string.IsNullOrWhiteSpace(name) ? originalName : name);
                                command.Parameters.AddWithValue("@category", string.IsNullOrWhiteSpace(category) ? originalCategory : category);
                                command.Parameters.AddWithValue("@description", string.IsNullOrWhiteSpace(budget) ? originalBudget : budget);
                                command.Parameters.AddWithValue("@amount", remaining);
                                command.Parameters.AddWithValue("@tl_id", selectedRecordId);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    budgetstatuslabel.Enabled = true;
                                    budgetstatuslabel.Visible = true;
                                    budgetstatuslabel.ForeColor = Color.DarkGreen;
                                    budgetstatuslabel.Text = "Record updated successfully.";
                                    PopulateDataGridView();
                                    LoadRecentCategories();
                                }
                                else
                                {
                                    budgetstatuslabel.ForeColor = Color.Maroon;
                                    budgetstatuslabel.Visible = true;
                                    budgetstatuslabel.Enabled = true;
                                    budgetstatuslabel.Text = "Failed to update record.";
                                    PopulateDataGridView();
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
            else
            {
                budgetstatuslabel.ForeColor = Color.Maroon;
                budgetstatuslabel.Visible = true;
                budgetstatuslabel.Enabled = true;
                budgetstatuslabel.Text = "Please select a row to update.";
            }
        }

        private bool IsRecordExists(string name, string category, decimal amount)
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

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            currentSearchQuery = searchQuery;

            FilterDataGridView(searchQuery);
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
                              "WHERE date LIKE @searchQuery " +
                              "   OR name LIKE @searchQuery " +
                              "   OR category LIKE @searchQuery" +
                              "   OR description LIKE @searchQuery" +
                              "   OR amount LIKE @searchQuery" +
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
            LoadRecentCategories();
        }

        private void RefreshAll()
        {

            PopulateDataGridView();
            LoadRecentCategories();
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

        private void ModTranLo_Load(object sender, EventArgs e)
        {

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

        private void ModTranLo_Enter(object sender, EventArgs e)
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
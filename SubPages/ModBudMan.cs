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
    public partial class ModBudMan : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
       
        public ModBudMan()
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

                    string sqlQuery = "SELECT bm_id, name, category, allocation, remaining FROM budman;";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        budmangrid.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid.Rows.Add();
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["bm_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["cat"].Value = row["category"];
                            budmangrid.Rows[rowIndex].Cells["alloc"].Value = row["allocation"];
                            budmangrid.Rows[rowIndex].Cells["rembud"].Value = row["remaining"];

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
                    pagesControl.SelectedIndex = 1;
                }
            }
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
        }

        private void modifydata_Click(object sender, EventArgs e)
        {
            if (budmangrid.SelectedRows.Count > 0)
            {
                string name = nametb.Text.Trim();
                string category = categorytb.Text.Trim();
                string budgetText = alloctb.Text.Trim();
                string remainingText = remtb.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) && string.IsNullOrWhiteSpace(category) && string.IsNullOrWhiteSpace(budgetText) && string.IsNullOrWhiteSpace(remainingText))
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
                decimal originalBudget = Convert.ToDecimal(selectedRow.Cells["alloc"].Value);
                decimal originalRemaining = Convert.ToDecimal(selectedRow.Cells["rembud"].Value);

                decimal budget = string.IsNullOrWhiteSpace(budgetText) ? originalBudget : Convert.ToDecimal(budgetText);
                decimal remaining = string.IsNullOrWhiteSpace(remainingText) ? originalRemaining : Convert.ToDecimal(remainingText);

                StringBuilder confirmationMessage = new StringBuilder("Are you sure you want to update this record with the following changes?\n\n");

                if (!string.IsNullOrWhiteSpace(name) && name != originalName)
                    confirmationMessage.AppendLine($"Name: {originalName} → {name}");

                if (!string.IsNullOrWhiteSpace(category) && category != originalCategory)
                    confirmationMessage.AppendLine($"Category: {originalCategory} → {category}");

                if (budget != originalBudget)
                    confirmationMessage.AppendLine($"Allocation: {originalBudget:C} → {budget:C}");

                if (remaining != originalRemaining)
                    confirmationMessage.AppendLine($"Remaining: {originalRemaining:C} → {remaining:C}");

                DialogResult result = MessageBox.Show(confirmationMessage.ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string sqlUpdate = "UPDATE budman SET name = @name, category = @category, allocation = @allocation, remaining = @remaining WHERE bm_id = @bm_id";

                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            using (MySqlCommand command = new MySqlCommand(sqlUpdate, connection))
                            {
                                command.Parameters.AddWithValue("@name", string.IsNullOrWhiteSpace(name) ? originalName : name);
                                command.Parameters.AddWithValue("@category", string.IsNullOrWhiteSpace(category) ? originalCategory : category);
                                command.Parameters.AddWithValue("@allocation", budget);
                                command.Parameters.AddWithValue("@remaining", remaining);
                                command.Parameters.AddWithValue("@bm_id", selectedRecordId);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    budgetstatuslabel.Enabled = true;
                                    budgetstatuslabel.Visible = true;
                                    budgetstatuslabel.ForeColor = Color.DarkGreen;
                                    budgetstatuslabel.Text = "Record updated successfully.";
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

        private void ModBudMan_Load(object sender, EventArgs e)
        {

        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = searchtextbox.Text.Trim();

            FilterDataGridView(searchQuery);
        }

        private void FilterDataGridView(string searchQuery)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM budman " +
                              "WHERE category LIKE @searchQuery " +
                              "   OR allocation LIKE @searchQuery " +
                              "   OR remaining LIKE @searchQuery" +
                              "   OR name LIKE @searchQuery";

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
                            budmangrid.Rows[rowIndex].Cells["id"].Value = row["bm_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["cat"].Value = row["category"];
                            budmangrid.Rows[rowIndex].Cells["alloc"].Value = row["allocation"];
                            budmangrid.Rows[rowIndex].Cells["rembud"].Value = row["remaining"];

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchlabel_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
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
            string yourAllocationColumnName = "alloc";
            string yourRemainingColumnName = "rembud";

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
    }
}
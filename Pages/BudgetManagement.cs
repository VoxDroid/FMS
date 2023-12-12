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
using static Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexesCollectionEditor;

namespace SPAAT.Pages
{
    public partial class BudgetManagement : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public BudgetManagement()
        {
            InitializeComponent();
            PopulateDataGridView();
            UpdateTotalEntriesLabel();
            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
        }

        private void CalculateAndDisplayTotalCharge2()
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
                TFC2.Text = "Total Alloc Amount: N/A";
            }
            else
            {
                TFC2.Text = $"Total Alloc Amount: \r\n₱{sum:n0}";
            }
        }

        private void CalculateAndDisplayTotalCharge()
        {
            int columnIndex = 3;
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
                TFC.Text = "Total Remaining Bud: N/A";
            }
            else
            {
                TFC.Text = $"Total Remaining Bud: ₱{sum:n0}";
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
                    pagesControl.SelectedIndex = 2;
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
                    pagesControl.SelectedIndex = 3;
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

        private void DeleteRecord(int bm_id)
        {
            string sqlDelete = "DELETE FROM budman WHERE bm_id = @bm_id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlDelete, connection))
                    {
                        command.Parameters.AddWithValue("@bm_id", bm_id);

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
                UpdateTotalEntriesLabel();
                CalculateAndDisplayTotalCharge();
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
            CalculateAndDisplayTotalCharge();
            CalculateAndDisplayTotalCharge2();
        }

        private void UpdateTotalEntriesLabel()
        {
            totalentrieslabel.Text = $"Total Entries: {Environment.NewLine} {budmangrid.Rows.Count}";
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

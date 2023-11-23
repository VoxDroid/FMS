using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace SPAAT.Pages
{
    public partial class Dashboard : UserControl
    {

        string connet = "Server=localhost;Database=fms;Username=root;Password=;";
        public Dashboard()
        {
            InitializeComponent();
            CalculateAndDisplayTotalRemainingBudget();
            CalculateAndDisplayTotalFunds();
            PopulateDataGridView();
            SetDefaultSelectedColumn();
        }

        private void budgetremainlabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTheSelectedItemButton_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalRemainingBudget();
        }

        private void CalculateAndDisplayTotalRemainingBudget()
        {
            string sqlSelectTotalRemaining = "SELECT SUM(remaining) FROM budman";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlSelectTotalRemaining, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalRemaining = Convert.ToDecimal(result);
                            budgetremainlabel.Text = $"Total Remaining Budget: {Environment.NewLine} ₱{totalRemaining:n0}";
                        }
                        else
                        {
                            budgetremainlabel.Text = "Total Remaining Budget: N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CalculateAndDisplayTotalFunds()
        {
            string sqlSelectTotalRemaining = "SELECT SUM(amount) FROM tranlo";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sqlSelectTotalRemaining, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal totalRemaining = Convert.ToDecimal(result);
                            totalfundslabel.Text = $"Total Funds: {Environment.NewLine} ₱{totalRemaining:n0}";
                        }
                        else
                        {
                            totalfundslabel.Text = "Total Funds: N/A";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalRemainingBudget();
            CalculateAndDisplayTotalFunds();
            PopulateDataGridView();
            SetDefaultSelectedColumn();
        }

        private void SetDefaultSelectedColumn()
        {
            DataGridView dataGridView = budmangrid;
            dataGridView.AllowUserToOrderColumns = false;

            dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.Programmatic;

            dataGridView.Sort(dataGridView.Columns[1], ListSortDirection.Descending);
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

        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT tl_id, date, name, description, category, amount FROM tranlo;";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
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
    }
}

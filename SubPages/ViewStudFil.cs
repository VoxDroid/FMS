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
namespace SPAAT.SubPages
{
    public partial class ViewStudFil : UserControl
    {
        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";
        public ViewStudFil()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string sqlQuery = "SELECT sn_id, name, debtamount FROM studdeb WHERE hasdebt = 1;";

                    using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        budmangrid.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid.Rows.Add();
                            budmangrid.Rows[rowIndex].Cells["sn_id"].Value = row["sn_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["debtamount"].Value = row["debtamount"];
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
            string yourRemainingColumnName = "debtamount";

            int yourRemainingColumnIndex = budmangrid.Columns[yourRemainingColumnName].Index;

            if (e.ColumnIndex == yourRemainingColumnIndex)
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
                    string sqlQuery = "SELECT * FROM studdeb WHERE hasdebt = 1 " +
                              "AND (name LIKE @searchQuery OR debtamount LIKE @searchQuery)";

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
                            budmangrid.Rows[rowIndex].Cells["sn_id"].Value = row["sn_id"];
                            budmangrid.Rows[rowIndex].Cells["name"].Value = row["name"];
                            budmangrid.Rows[rowIndex].Cells["debtamount"].Value = row["debtamount"];
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
    }
}

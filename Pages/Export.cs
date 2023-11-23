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
using System.IO;
using ClosedXML.Excel;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Data.SQLite;
using Newtonsoft.Json;

namespace SPAAT.Pages
{
    public partial class Export : UserControl
    {
        string connet = "Server=localhost;Database=fms;Username=root;Password=;";
        public Export()
        {
            InitializeComponent();
            PopulateDataGridView();
            PopulateDataGridView2();
        }
        private void PopulateDataGridView2()
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
                        budmangrid2.Rows.Clear();
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int rowIndex = budmangrid2.Rows.Add();
                            budmangrid2.Rows[rowIndex].Cells["ids"].Value = row["tl_id"];
                            budmangrid2.Rows[rowIndex].Cells["date"].Value = row["date"];
                            budmangrid2.Rows[rowIndex].Cells["names"].Value = row["name"];
                            budmangrid2.Rows[rowIndex].Cells["desc"].Value = row["description"];
                            budmangrid2.Rows[rowIndex].Cells["cats"].Value = row["category"];
                            budmangrid2.Rows[rowIndex].Cells["amount"].Value = row["amount"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void budmangrid2_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = budmangrid2.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellText = cell.Value?.ToString();

                if (!string.IsNullOrWhiteSpace(cellText))
                {
                    guna2HtmlToolTip1.SetToolTip(budmangrid2, cellText);
                }
                else
                {
                    guna2HtmlToolTip1.SetToolTip(budmangrid2, null);
                }
            }
        }

        private void budmangrid2_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            guna2HtmlToolTip1.SetToolTip(budmangrid2, null);
        }

        private void budmangrid2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string yourAllocationColumnName = "amount";

            int yourAllocationColumnIndex = budmangrid2.Columns[yourAllocationColumnName].Index;

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

            int yourDateColumnIndex = budmangrid2.Columns[yourDateColumnName].Index;

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

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableExportButton();
            int selectedIndex = guna2ComboBox2.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    bunifuPages1.SelectTab(select);
                    PopulateDataGridView();
                    PopulateDataGridView2();
                    break;
                case 1:
                    bunifuPages1.SelectTab(budman);
                    PopulateDataGridView();
                    PopulateDataGridView2();
                    break;
                case 2:
                    bunifuPages1.SelectTab(tranlo);
                    PopulateDataGridView();
                    PopulateDataGridView2();
                    break;
                default:
                    break;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableExportButton();
        }

        private void EnableExportButton()
        {
            bool isTableSelected = guna2ComboBox1.SelectedIndex > 0;
            bool isFormatSelected = guna2ComboBox2.SelectedIndex > 0;

            exportbutton.Enabled = isTableSelected && isFormatSelected;
        }

        private void exportbutton_Click(object sender, EventArgs e)
        {
            if (guna2ComboBox2.SelectedIndex < 1 || guna2ComboBox1.SelectedIndex < 1)
            {
                MessageBox.Show("Please select both a table and a format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;
                    string selectedTable = guna2ComboBox2.SelectedItem.ToString();
                    string selectedFormat = guna2ComboBox1.SelectedItem.ToString();

                    string fileExtension = GetFileExtension(selectedFormat);

                    if (fileExtension == null)
                    {
                        MessageBox.Show("Invalid format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string fileName = $"{selectedTable}_Export.{fileExtension}";
                    string filePath = Path.Combine(selectedFolder, fileName);

                    if (selectedTable == "Budget Management")
                    {
                        ExportData(budmangrid, filePath, selectedFormat);
                    }
                    else if (selectedTable == "Transaction Logs")
                    {
                        ExportData(budmangrid2, filePath, selectedFormat);
                    }
                }
            }
        }


        private string GetFileExtension(string selectedFormat)
        {
            switch (selectedFormat.ToLower())
            {
                case "csv":
                    return "csv";
                case "excel":
                    return "xlsx";
                case "pdf":
                    return "pdf";
                case "json":
                    return "json";
                case "xml":
                    return "xml";
                case "sqlite":
                    return "sqlite";
                default:
                    return null;
            }
        }

        private void ExportData(DataGridView dataGridView, string filePath, string format)
        {
            try
            {
                switch (format.ToLower())
                {
                    case "csv":
                        ExportToCsv(dataGridView, filePath);
                        break;
                    case "excel":
                        ExportToExcel(dataGridView, filePath);
                        break;
                    case "pdf":
                        ExportToPdf(dataGridView, filePath);
                        break;
                    case "json":
                        ExportToJson(dataGridView, filePath);
                        break;
                    case "xml":
                        ExportToXml(dataGridView, filePath);
                        break;
                    case "sqlite":
                        ExportToSQLite(dataGridView, filePath);
                        break;
                    default:
                        MessageBox.Show("Invalid format selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToXml(DataGridView dataGridView, string fileName)
        {
            try
            {
                var dataSet = new DataSet();
                var dataTable = GetDataTable(dataGridView);

                dataTable.TableName = "ExportedData";

                dataSet.Tables.Add(dataTable);

                dataSet.WriteXml(fileName);

                MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to XML: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToSQLite(DataGridView dataGridView, string fileName)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3;"))
                {
                    connection.Open();

                    // Get the selected table name from the combo box
                    string selectedTable = guna2ComboBox2.SelectedItem.ToString().Replace(" ", "_");

                    // Create a dynamic SQL command to create the table
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        StringBuilder createTableSql = new StringBuilder($"CREATE TABLE IF NOT EXISTS {selectedTable} (");

                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            createTableSql.Append($"{column.HeaderText.Replace(" ", "_")} TEXT, ");
                        }

                        // Remove the trailing comma and space
                        createTableSql.Length -= 2;

                        createTableSql.Append(")");

                        command.CommandText = createTableSql.ToString();
                        command.ExecuteNonQuery();
                    }

                    // Insert data into the dynamically created table
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            StringBuilder insertDataSql = new StringBuilder($"INSERT INTO {selectedTable} (");

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                insertDataSql.Append($"{column.HeaderText.Replace(" ", "_")}, ");
                                command.Parameters.AddWithValue($"@{column.HeaderText.Replace(" ", "_")}", row.Cells[column.Index].Value?.ToString() ?? "");
                            }

                            // Remove the trailing comma and space
                            insertDataSql.Length -= 2;

                            insertDataSql.Append(") VALUES (");

                            foreach (DataGridViewColumn column in dataGridView.Columns)
                            {
                                insertDataSql.Append($"@{column.HeaderText.Replace(" ", "_")}, ");
                            }

                            // Remove the trailing comma and space
                            insertDataSql.Length -= 2;

                            insertDataSql.Append(")");

                            command.CommandText = insertDataSql.ToString();
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }

                    MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to SQLite: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToJson(DataGridView dataGridView, string fileName)
        {
            var dataTable = GetDataTable(dataGridView);
            var json = JsonConvert.SerializeObject(dataTable, Formatting.Indented);
            File.WriteAllText(fileName, json);

            MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void ExportToCsv(DataGridView dataGridView, string fileName)
        {
            try
            {
                var header = string.Join(",", dataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));
                var lines = dataGridView.Rows.Cast<DataGridViewRow>()
                    .Select(row => string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value)));

                File.WriteAllLines(fileName, new[] { header }.Concat(lines));

                MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to CSV: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPdf(DataGridView dataGridView, string fileName)
        {
            try
            {
                var pdfDocument = new PdfDocument();
                var pdfPage = pdfDocument.AddPage();

                var gfx = XGraphics.FromPdfPage(pdfPage);
                var font = new XFont("Century Gothic", 7);

                var dataTable = GetDataTable(dataGridView);

                float xPosition = 10;
                float yPosition = 10;

                foreach (DataColumn column in dataTable.Columns)
                {
                    gfx.DrawString(column.ColumnName, font, XBrushes.Black, xPosition, yPosition);
                    xPosition += 100;
                }

                yPosition += 20;

                foreach (DataRow row in dataTable.Rows)
                {
                    xPosition = 10;

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        gfx.DrawString(row[column].ToString(), font, XBrushes.Black, xPosition, yPosition);
                        xPosition += 100;
                    }

                    yPosition += 20;
                }

                pdfDocument.Save(fileName);

                MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GetDataTable(DataGridView dataGridView)
        {
            var dataTable = new DataTable();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }
        private void ExportToExcel(DataGridView dataGridView, string fileName)
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                workbook.SaveAs(fileName);

                MessageBox.Show($"Data exported to {fileName} successfully.", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

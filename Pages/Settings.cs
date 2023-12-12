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
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace SPAAT.Pages
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            guna2HtmlToolTip1.SetToolTip(RBM, "Delete and reset all data stored in Budget Management.");
            guna2HtmlToolTip1.SetToolTip(RTL, "Delete and reset all data stored in Transaction Logs.");
            guna2HtmlToolTip1.SetToolTip(RSF, "Delete and reset all data stored in Student File.");
            guna2HtmlToolTip1.SetToolTip(backupdatabase, "Generates a backup database zapisaxisfms_backup.sql file");
            guna2HtmlToolTip1.SetToolTip(importdatabase, "Overwrites and deletes the existing database with the data from a backup. ");
            guna2HtmlToolTip1.SetToolTip(guna2Button1, "Reset and recreate the entire database.");
        }


        private bool ConfirmDeletionWithResetKey()
        {
            string resetKeyFromDatabase = GetResetKeyFromDatabase();

            do
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox("Enter the reset key to confirm operation:", "Confirmation", "");

                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Operation Canceled. No key entered.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (userInput.Trim().Equals(resetKeyFromDatabase, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect reset key. Please try again.", "Incorrect Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            while (true);
        }

        private string GetResetKeyFromDatabase()
        {
            string resetKey = "";

            try
            {
                string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";

                using (MySqlConnection connection = new MySqlConnection(connet))
                {
                    connection.Open();

                    string selectQuery = "SELECT reset_key FROM resetkeys";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                resetKey = reader["reset_key"].ToString();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resetKey;
        }

        private void RBM_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "Are you sure you want to delete all records from Budget Management?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM budman";

                            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    string resetAutoIncrementQuery = "ALTER TABLE budman AUTO_INCREMENT = 1";
                                    using (MySqlCommand resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, connection))
                                    {
                                        resetAutoIncrementCommand.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("All records deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No records found to delete.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RTL_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "Are you sure you want to delete all records from Transaction Logs?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            string deleteQuery = "DELETE FROM tranlo";

                            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    string resetAutoIncrementQuery = "ALTER TABLE tranlo AUTO_INCREMENT = 1";
                                    using (MySqlCommand resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, connection))
                                    {
                                        resetAutoIncrementCommand.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("All records deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No records found to delete.", "Delete Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RSF_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "Are you sure you want to delete all records from Student File?",
                        "Final Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        string connet = "Server=localhost;Database=zapisaxisfms;Username=root;Password=;";

                        using (MySqlConnection connection = new MySqlConnection(connet))
                        {
                            connection.Open();

                            DeleteTableRecords(connection, "studfil");

                            DeleteTableRecords(connection, "studdeb");

                            DeleteTableRecords(connection, "studname");

                            MessageBox.Show("All records deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTableRecords(MySqlConnection connection, string tableName)
        {
            string deleteQuery = $"DELETE FROM {tableName}";

            using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string resetAutoIncrementQuery = $"ALTER TABLE {tableName} AUTO_INCREMENT = 1";
                    using (MySqlCommand resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, connection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        private void backupdatabase_Click(object sender, EventArgs e)
        {
            string dbHost = "localhost";
            string dbUsername = "root";
            string dbPassword = "";
            string dbName = "zapisaxisfms";

            string connectionString = $"Server={dbHost};Database={dbName};User ID={dbUsername};Password={dbPassword};";

            bool confirmDeletion = ConfirmDeletionWithResetKey();

            if (!confirmDeletion)
            {
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = $"{dbName}_backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql",
                Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*",
                Title = "Save Backup File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFile = saveFileDialog.FileName;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = connection;

                                MemoryStream memoryStream = new MemoryStream();
                                mb.ExportToMemoryStream(memoryStream);

                                File.WriteAllBytes(backupFile, memoryStream.ToArray());

                                MessageBox.Show($"Backup successful. File saved to: {backupFile}", "Backup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Backup failed. Error: {ex.Message}", "Backup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool ConfirmImportWithConfirmationKey()
        {
            do
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "To proceed with the import, type 'IMPORT' in the box below:",
                    "Import Confirmation",
                    ""
                );

                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Import canceled. No confirmation text entered.", "Import Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (userInput.Trim().Equals("IMPORT", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Import canceled. Incorrect confirmation text.", "Import Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            while (true);
        }

        private void importdatabase_Click(object sender, EventArgs e)
        {
            string dbHost = "localhost";
            string dbUsername = "root";
            string dbPassword = "";
            string dbName = "zapisaxisfms";

            string connectionString = $"Server={dbHost};Database={dbName};User ID={dbUsername};Password={dbPassword};";

            bool confirmDeletion = ConfirmDeletionWithResetKey();

            if (!confirmDeletion)
            {
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*",
                Title = "Select SQL File to Import"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult importConfirmation = MessageBox.Show(
                    "Importing will override the existing database with the data from the selected file. Are you sure you want to proceed?",
                    "Import Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (importConfirmation == DialogResult.Yes)
                {
                    bool confirmImport = ConfirmImportWithConfirmationKey();

                    if (confirmImport)
                    {
                        string sqlFilePath = openFileDialog.FileName;

                        try
                        {
                            string sqlScript = File.ReadAllText(sqlFilePath);

                            using (MySqlConnection connection = new MySqlConnection(connectionString))
                            {
                                connection.Open();

                                using (MySqlCommand cmd = new MySqlCommand(sqlScript, connection))
                                {
                                    cmd.ExecuteNonQuery();

                                    DialogResult Res = MessageBox.Show($"Import successful.", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (Res == DialogResult.OK)
                                    {
                                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                                        Application.Exit();
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Import failed. Error: {ex.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool confirmDeletion = ConfirmDeletionWithResetKey();

                if (confirmDeletion)
                {
                    DialogResult finalConfirmation = MessageBox.Show(
                        "This action will reset the entire database, and all existing data will be lost. Do you want to proceed?",
                        "Reset Database Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (finalConfirmation == DialogResult.Yes)
                    {
                        if (ConfirmResetWithConfirmationKey())
                        {
                            try
                            {
                                string connet = "Server=localhost;Username=root;Password=;";

                                using (MySqlConnection connection = new MySqlConnection(connet))
                                {
                                    connection.Open();

                                    DropDatabaseIfExists(connection, "zapisaxisfms");

                                    CreateDatabase(connection, "zapisaxisfms");

                                    connection.ChangeDatabase("zapisaxisfms");

                                    DatabaseInitializer.InitializeDatabase();

                                    DialogResult Res = MessageBox.Show("Database reset successfully.", "Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (Res == DialogResult.OK)
                                    {
                                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                                        Application.Exit();
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Reset canceled.", "Reset Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmResetWithConfirmationKey()
        {
            do
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox(
                    "To proceed with the reset, type 'RESET' in the box below:",
                    "Reset Confirmation",
                    ""
                );

                if (string.IsNullOrEmpty(userInput))
                {
                    MessageBox.Show("Reset canceled. No confirmation text entered.", "Reset Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (userInput.Trim().Equals("RESET", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Reset canceled.", "Reset Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            while (true);
        }

        private static void DropDatabaseIfExists(MySqlConnection connection, string databaseName)
        {
            string dropDatabaseQuery = $"DROP DATABASE IF EXISTS {databaseName}";
            using (MySqlCommand dropDatabaseCommand = new MySqlCommand(dropDatabaseQuery, connection))
            {
                dropDatabaseCommand.ExecuteNonQuery();
            }
        }

        private static void CreateDatabase(MySqlConnection connection, string databaseName)
        {
            string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
            using (MySqlCommand createDatabaseCommand = new MySqlCommand(createDatabaseQuery, connection))
            {
                createDatabaseCommand.ExecuteNonQuery();
            }
        }
    }
}

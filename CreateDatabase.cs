using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public static class DatabaseInitializer
{
    public static void InitializeDatabase()
    {
        try
        {
            string connet = "Server=localhost;Username=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connet))
            {
                connection.Open();

                string checkDatabaseQuery = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'fms'";
                using (MySqlCommand checkDatabaseCommand = new MySqlCommand(checkDatabaseQuery, connection))
                {
                    object result = checkDatabaseCommand.ExecuteScalar();
                    if (result == null)
                    {
                        string createDatabaseQuery = "CREATE DATABASE fms";
                        using (MySqlCommand createDatabaseCommand = new MySqlCommand(createDatabaseQuery, connection))
                        {
                            createDatabaseCommand.ExecuteNonQuery();
                        }
                    }
                }

                connection.ChangeDatabase("fms");


                CreateTableIfNotExists(connection, "budman", "CREATE TABLE budman (bm_id int(255) NOT NULL AUTO_INCREMENT, name varchar(255) NOT NULL, category varchar(255) NOT NULL, allocation int(255) NOT NULL, remaining int(255) NOT NULL, PRIMARY KEY (bm_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "resetkeys", "CREATE TABLE resetkeys (reset_key varchar(255) NOT NULL, id int(255) NOT NULL AUTO_INCREMENT, PRIMARY KEY (id), UNIQUE KEY unique_reset_key (reset_key)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "su", "CREATE TABLE su (su_id int(255) NOT NULL AUTO_INCREMENT, user_id int(255) NOT NULL, PRIMARY KEY (su_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "INSERT INTO su (user_id) VALUES (1)");

                CreateTableIfNotExists(connection, "tranlo", "CREATE TABLE tranlo (tl_id int(255) NOT NULL AUTO_INCREMENT, name varchar(255) NOT NULL, date varchar(255) NOT NULL, description varchar(255) NOT NULL, category varchar(255) NOT NULL, amount int(255) NOT NULL, PRIMARY KEY (tl_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "users", "CREATE TABLE users (user_id int(255) NOT NULL AUTO_INCREMENT, username varchar(255) NOT NULL, password varchar(255) NOT NULL, PRIMARY KEY (user_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "INSERT INTO users (username, password) VALUES ('admin', 'admin')");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void CreateTableIfNotExists(MySqlConnection connection, string tableName, string createTableQuery, string insertDefaultDataQuery)
    {
        string checkTableQuery = $"SHOW TABLES LIKE '{tableName}'";
        using (MySqlCommand checkTableCommand = new MySqlCommand(checkTableQuery, connection))
        {
            object result = checkTableCommand.ExecuteScalar();
            if (result == null)
            {
                using (MySqlCommand createTableCommand = new MySqlCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                if (!string.IsNullOrEmpty(insertDefaultDataQuery))
                {
                    using (MySqlCommand insertDefaultDataCommand = new MySqlCommand(insertDefaultDataQuery, connection))
                    {
                        insertDefaultDataCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
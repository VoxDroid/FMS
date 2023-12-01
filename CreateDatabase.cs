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

                CreateDatabaseIfNotExists(connection, "fms");

                connection.ChangeDatabase("fms");

                CreateTableIfNotExists(connection, "budman", "CREATE TABLE budman (bm_id int(255) NOT NULL AUTO_INCREMENT, name varchar(255) NOT NULL, category varchar(255) NOT NULL, allocation int(255) NOT NULL, remaining int(255) NOT NULL, PRIMARY KEY (bm_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "resetkeys", "CREATE TABLE resetkeys (reset_key varchar(255) NOT NULL, id int(255) NOT NULL AUTO_INCREMENT, PRIMARY KEY (id), UNIQUE KEY unique_reset_key (reset_key)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "su", "CREATE TABLE su (su_id int(255) NOT NULL AUTO_INCREMENT, user_id int(255) NOT NULL, PRIMARY KEY (su_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "ALTER TABLE su AUTO_INCREMENT = 1");

                CreateTableIfNotExists(connection, "tranlo", "CREATE TABLE tranlo (tl_id int(255) NOT NULL AUTO_INCREMENT, name varchar(255) NOT NULL, date varchar(255) NOT NULL, description varchar(255) NOT NULL, category varchar(255) NOT NULL, amount int(255) NOT NULL, PRIMARY KEY (tl_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "users", "CREATE TABLE users (user_id int(255) NOT NULL AUTO_INCREMENT, username varchar(255) NOT NULL, password varchar(255) NOT NULL, PRIMARY KEY (user_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "INSERT INTO users (username, password) VALUES ('admin', 'admin')", "ALTER TABLE users AUTO_INCREMENT = 1");

                CreateTableIfNotExists(connection, "studname", "CREATE TABLE studname (sn_id int(255) NOT NULL AUTO_INCREMENT, name varchar(255) NOT NULL, PRIMARY KEY (sn_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CreateTableIfNotExists(connection, "studdeb", "CREATE TABLE studdeb (sn_id int(255) NOT NULL, name varchar(255) NOT NULL, hasdebt bit(1) NOT NULL, debtamount int(255) NOT NULL, PRIMARY KEY (sn_id), CONSTRAINT FK_StudentDebt FOREIGN KEY (sn_id) REFERENCES studname (sn_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci", "");

                CreateTableIfNotExists(connection, "studfil", "CREATE TABLE studfil (pm_id int(255) NOT NULL AUTO_INCREMENT, sn_id int(255) NOT NULL, name varchar(255) NOT NULL, charge int(255) NOT NULL, amountpaid int(255) NOT NULL, paymentdate varchar(255) NOT NULL, paymentstatus varchar(255) NOT NULL, PRIMARY KEY (pm_id), KEY sn_id (sn_id), CONSTRAINT studfil_ibfk_1 FOREIGN KEY (sn_id) REFERENCES studname (sn_id)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci AUTO_INCREMENT=1", "");

                CheckAndInsertDefaultUser(connection);
                CheckAndInsertDefaultSu(connection);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static void CreateDatabaseIfNotExists(MySqlConnection connection, string databaseName)
    {
        string checkDatabaseQuery = $"SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '{databaseName}'";
        using (MySqlCommand checkDatabaseCommand = new MySqlCommand(checkDatabaseQuery, connection))
        {
            object result = checkDatabaseCommand.ExecuteScalar();
            if (result == null)
            {
                string createDatabaseQuery = $"CREATE DATABASE {databaseName}";
                using (MySqlCommand createDatabaseCommand = new MySqlCommand(createDatabaseQuery, connection))
                {
                    createDatabaseCommand.ExecuteNonQuery();
                }
            }
        }
    }

    private static void CreateTableIfNotExists(MySqlConnection connection, string tableName, string createTableQuery, string insertDefaultDataQuery, string resetAutoIncrementQuery = "")
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

                if (!string.IsNullOrEmpty(resetAutoIncrementQuery))
                {
                    using (MySqlCommand resetAutoIncrementCommand = new MySqlCommand(resetAutoIncrementQuery, connection))
                    {
                        resetAutoIncrementCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    private static void CheckAndInsertDefaultUser(MySqlConnection connection)
    {
        string checkDefaultUserQuery = "SELECT * FROM users WHERE user_id = 1";
        using (MySqlCommand checkDefaultUserCommand = new MySqlCommand(checkDefaultUserQuery, connection))
        {
            using (MySqlDataReader reader = checkDefaultUserCommand.ExecuteReader())
            {
                if (!reader.Read())
                {
                    reader.Close();

                    string insertDefaultUserQuery = "INSERT INTO users (user_id, username, password) VALUES (1, 'admin', 'admin')";
                    using (MySqlCommand insertDefaultUserCommand = new MySqlCommand(insertDefaultUserQuery, connection))
                    {
                        insertDefaultUserCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    private static void CheckAndInsertDefaultSu(MySqlConnection connection)
    {
        string checkDefaultSuQuery = "SELECT * FROM su WHERE su_id = 1";
        using (MySqlCommand checkDefaultSuCommand = new MySqlCommand(checkDefaultSuQuery, connection))
        {
            using (MySqlDataReader reader = checkDefaultSuCommand.ExecuteReader())
            {
                if (!reader.Read())
                {
                    reader.Close(); 

                    string insertDefaultSuQuery = "INSERT INTO su (su_id, user_id) VALUES (1, 1)";
                    using (MySqlCommand insertDefaultSuCommand = new MySqlCommand(insertDefaultSuQuery, connection))
                    {
                        insertDefaultSuCommand.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
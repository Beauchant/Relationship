using Microsoft.VisualBasic;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

public class SQLiteDatabaseCommands
{
    private SQLiteConnection connection;
    public SQLiteDatabaseCommands(string connectionString)
    {
        connection = new SQLiteConnection(connectionString);
    }

    public void OpenConnection()
    {
        try
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            // Enable foreign keys
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();
            }

            // Display success message in ComboBox
            //MessageBox.Show("Connection opened successfully");
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            string msg = $"Failed to open connection: {ex.Message}";
            MessageBox.Show(msg);
        }
    }

    public void CloseConnection()
    {
        try
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }

            // Display success message in ComboBox
            //MessageBox.Show("Connection closed successfully");
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            string msg =  $"Failed to close connection: {ex.Message}";
            MessageBox.Show(msg);
        }
    }

    public void InsertData(string tableName, Dictionary<string, object> columnValues, Label label, string message)
    {
        // Check if the user already exists in the database
        if (UserExists(tableName, columnValues))
        {
            MessageBox.Show("Data already exist!");
        }
        else
        {
            string columns = string.Join(", ", columnValues.Keys);
            string parameterNames = string.Join(", ", columnValues.Keys.Select(key => "@" + key));

            string query = $"INSERT INTO {tableName} ({columns}) VALUES ({parameterNames})";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                foreach (var kvp in columnValues)
                {
                    command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                }

                command.ExecuteNonQuery();
                ShowMessage(label, message, 3000);
            }
        }
    }

    private bool UserExists(string tableName, Dictionary<string, object> columnValues)
    {
        string conditions = string.Join(" AND ", columnValues.Keys.Select(key => $"{key} = @{key}"));

        string query = $"SELECT COUNT(*) FROM {tableName} WHERE {conditions}";

        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        {
            foreach (var kvp in columnValues)
            {
                command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
            }

            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }
    }

    public void EditData(string tableName, int id, Dictionary<string, object> columnValues)
    {
        try
        {
            string setColumns = string.Join(", ", columnValues.Keys.Select(key => $"{key} = @{key}"));

            string query = $"UPDATE {tableName} SET {setColumns} WHERE Id = @Id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                foreach (var kvp in columnValues)
                {
                    command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                }

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            MessageBox.Show($"Edit Failed: {ex.Message}");
        }
    }

    public void EditData(string tableName, string id, Dictionary<string, object> columnValues)
    {
        try
        {
            string setColumns = string.Join(", ", columnValues.Keys.Select(key => $"{key} = @{key}"));

            string query = $"UPDATE {tableName} SET {setColumns} WHERE Id = @Id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                foreach (var kvp in columnValues)
                {
                    command.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                }

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            MessageBox.Show($"Edit Failed: {ex.Message}");
        }
    }

    public void DeleteData(string tableName, int id)
    {
        try
        {
            string query = $"DELETE FROM {tableName} WHERE Id = @Id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

            // Display success message in ComboBox
            //MessageBox.Show("Delete successful");
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            string msg = $"Delete Failde: {ex.Message}";
            MessageBox.Show(msg);
        }
    }

    public void DeleteData(string tableName, string id)
    {
        try
        {
            string query = $"DELETE FROM {tableName} WHERE Id = @Id";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }

            // Display success message in ComboBox
            //MessageBox.Show("Delete successful");
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            string msg = $"Delete Failde: {ex.Message}";
            MessageBox.Show(msg);
        }
    }

    public DataTable GetAllData(string tableName, DataGridView dataGridView)
    {
        DataTable dataTable = new DataTable();

        try
        {
            using (SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            dataGridView.DataSource = dataTable;

            // Display success message in ComboBox
            //MessageBox.Show("Data retrieved successfully");
        }
        catch (Exception ex)
        {
            // Display error message in ComboBox
            string msg = $"Failed to retrieve data: {ex.Message}";
            MessageBox.Show(msg);
        }

        return dataTable;
    }

    public void LoadDataIntoDataGridView(string tableName, DataGridView dataGridView)
    {
        string query = $"SELECT * FROM {tableName}";

        using (SQLiteCommand command = new SQLiteCommand(query, connection))
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
        }
    }

    // Other database commands...

    public DataTable GetDataForComboBox(string query)
    {
        DataTable dataTable = new DataTable();

        try
        {
            // Establish a connection to your SQLite database
            OpenConnection();

            // Create a SQLiteCommand using your connection
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                // Create a SQLiteDataAdapter and populate the DataTable
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions
            Console.WriteLine("Error retrieving data: " + ex.Message);
        }
        finally
        {
            // Close the connection
            CloseConnection();
        }

        return dataTable;
    }

    public void ShowMessage(Label label, string message, int duration)
    {
        label.Text = message;

        System.Windows.Forms.Timer timerMessage = new System.Windows.Forms.Timer();
        timerMessage.Interval = duration;
        timerMessage.Tick += (sender, e) =>
        {
            label.Text = "";
            timerMessage.Stop();
            timerMessage.Dispose();
        };
        timerMessage.Start();
    }

    public void ExportSQLiteToExcel(string databasePath, string tableName, string sheetName)
    {
        // Create a connection to the SQLite database
        using (var connection = new SQLiteConnection($"Data Source={databasePath}"))
        {
            connection.Open();

            // Create a command to retrieve data from the database
            using (var command = new SQLiteCommand($"SELECT * FROM {tableName}", connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    // Prompt the user to select the file path to save the Excel file
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.ShowDialog();

                    if (saveFileDialog.FileName != "")
                    {
                        string excelPath = saveFileDialog.FileName;

                        // Create a new Excel package
                        using (var package = new ExcelPackage())
                        {
                            // Create a new worksheet in the Excel package
                            var worksheet = package.Workbook.Worksheets.Add(sheetName);

                            // Write the column headers to the worksheet
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = reader.GetName(i);
                            }

                            // Write the data rows to the worksheet
                            int row = 2;
                            while (reader.Read())
                            {
                                for (int col = 0; col < reader.FieldCount; col++)
                                {
                                    worksheet.Cells[row, col + 1].Value = reader.GetValue(col);
                                }
                                row++;
                            }

                            // Save the Excel package to the selected file path
                            FileInfo excelFile = new FileInfo(excelPath);
                            package.SaveAs(excelFile);
                        }
                    }
                }
            }
        }
    }

    public void ExportSQLiteToExcel(string databasePath, List<string> tableNames, List<string> sheetNames)
    {
        // Create a connection to the SQLite database
        using (var connection = new SQLiteConnection($"Data Source={databasePath}"))
        {
            connection.Open();

            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                for (int i = 0; i < tableNames.Count; i++)
                {
                    string tableName = tableNames[i];
                    string sheetName = sheetNames[i];

                    // Create a command to retrieve data from the database
                    using (var command = new SQLiteCommand($"SELECT * FROM {tableName}", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            // Create a new worksheet in the Excel package
                            var worksheet = package.Workbook.Worksheets.Add(sheetName);

                            // Write the column headers to the worksheet
                            for (int col = 0; col < reader.FieldCount; col++)
                            {
                                worksheet.Cells[1, col + 1].Value = reader.GetName(col);
                            }

                            // Write the data rows to the worksheet
                            int row = 2;
                            while (reader.Read())
                            {
                                for (int col = 0; col < reader.FieldCount; col++)
                                {
                                    worksheet.Cells[row, col + 1].Value = reader.GetValue(col);
                                }
                                row++;
                            }
                        }
                    }
                }

                // Prompt the user to select the file path to save the Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string excelPath = saveFileDialog.FileName;

                    // Save the Excel package to the selected file path
                    FileInfo excelFile = new FileInfo(excelPath);
                    package.SaveAs(excelFile);
                }
            }
        }
    }

    public DataTable GetDataWithParameters(string query, Dictionary<string, object> parameters)
    {
        DataTable dataTable = new DataTable();

        try
        {
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                foreach (var kvp in parameters)
                {
                    command.Parameters.AddWithValue(kvp.Key, kvp.Value);
                }

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error retrieving data: {ex.Message}");
        }

        return dataTable;
    }

    public void CreateForeignKeyConstraint(string referencingTable, string foreignKeyColumn, string referencedTable, string primaryKeyColumn, string onDeleteAction = "SET NULL", string onUpdateAction = "CASCADE")
    {
        try
        {
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                // Enable foreign keys if not already enabled
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();

                // Define the foreign key constraint
                string constraintName = $"fk_{referencingTable}_{referencedTable}";
                command.CommandText = $"ALTER TABLE {referencingTable} ADD CONSTRAINT {constraintName} FOREIGN KEY ({foreignKeyColumn}) REFERENCES {referencedTable} ({primaryKeyColumn}) ON DELETE {onDeleteAction} ON UPDATE {onUpdateAction};";
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions or display an error message
            MessageBox.Show($"Failed to create foreign key constraint: {ex.Message}");
        }
    }

    public void InitializeDatabase()
    {
        try
        {
            // Open the connection to the database
            OpenConnection();

            // Enable foreign keys if not already enabled
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();
            }

            // Define the foreign key constraints for the "Session" table
            string createSessionTableQuery = "CREATE TABLE IF NOT EXISTS Session (" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Session TEXT NOT NULL," +
                "Start_Date TEXT NOT NULL," +
                "End_Date TEXT NOT NULL," +
                "Active TEXT NOT NULL" +
                ");";

            using (SQLiteCommand command = new SQLiteCommand(createSessionTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Backup the data from the "Option" table
            DataTable optionData = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Option", connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(optionData);
                }
            }

            // Drop the "Option" table
            string dropOptionTableQuery = "DROP TABLE IF EXISTS Option;";
            using (SQLiteCommand command = new SQLiteCommand(dropOptionTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Create the "Option" table with the foreign key constraint
            string createOptionTableQuery = "CREATE TABLE IF NOT EXISTS Option (" +
                "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Option TEXT NOT NULL," +
                "SessionID INTEGER," +
                "FOREIGN KEY (SessionID) REFERENCES Session(ID) ON DELETE SET NULL ON UPDATE CASCADE" +
                ");";

            using (SQLiteCommand command = new SQLiteCommand(createOptionTableQuery, connection))
            {
                command.ExecuteNonQuery();
            }

            // Restore the data to the new "Option" table
            using (SQLiteCommand command = new SQLiteCommand(connection))
            {
                foreach (DataRow row in optionData.Rows)
                {
                    command.CommandText = "INSERT INTO Option (Option, SessionID) VALUES (@Option, @SessionID);";
                    command.Parameters.AddWithValue("@Option", row["Option"]);
                    command.Parameters.AddWithValue("@SessionID", row["SessionID"]);
                    command.ExecuteNonQuery();
                }
            }

            // Close the connection
            CloseConnection();
        }
        catch (Exception ex)
        {
            // Handle any exceptions or display an error message
            MessageBox.Show($"Database initialization failed: {ex.Message}");
        }
    }

    public void LoadDataIntoDataGridViewWithSession(string referencingTable, string referencedTable, DataGridView dataGridView)
    {
        string query = $"SELECT {referencingTable}.*, {referencedTable}.Session AS Session FROM {referencingTable} " +
                       $"LEFT JOIN {referencedTable} ON {referencingTable}.SessionID = {referencedTable}.ID";

        string query1 = $"SELECT {referencingTable}.*, {referencedTable}.Session AS SessionName FROM {referencingTable} " +
                   $"LEFT JOIN {referencedTable} ON {referencingTable}.SessionID = {referencedTable}.ID";

        try
        {
            OpenConnection();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Hide the SessionID column
                    dataTable.Columns["SessionID"].ColumnMapping = MappingType.Hidden;

                    dataGridView.DataSource = dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to load data: {ex.Message}");
        }
        finally
        {
            CloseConnection();
        }
    }

}

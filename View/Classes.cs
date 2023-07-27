using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relationship.View
{
    public partial class Classes : Form
    {
        static string connectionString = @"Data Source = Relationship.db";
        SQLiteDatabaseCommands dbCommands = new SQLiteDatabaseCommands(connectionString);
        public Classes()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtClasse.Texts == "" || cmbSession.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                try
                {
                    Models.Classe classe = new Models.Classe(txtClasse.Texts, cmbSession.SelectedItem.ToString());

                    dbCommands.OpenConnection();

                    // Inserting data into table "Classe"
                    DataRowView selectedRow = (DataRowView)cmbSession.SelectedItem;
                    int sessionID = Convert.ToInt32(selectedRow["ID"]);
                    string session = selectedRow["Session"].ToString();

                    Dictionary<string, object> columnValues1 = new Dictionary<string, object>
                    {
                        { "Option", classe.ClasseName },
                        { "SessionID", sessionID },
                    };

                    string message = "Add Successfully!";
                    dbCommands.InsertData("Option", columnValues1, lblMessage, message);

                    dbCommands.CloseConnection();

                    // dbCommands.LoadDataIntoDataGridView("Option", dataGridView1);
                    LoadDataIntoDataGridViewWithSession("Option", dataGridView1);

                    Clear();
                }
                catch (SQLiteException ex)
                {
                    // Handle unique constraint violation error
                    if ((SQLiteErrorCode)ex.ErrorCode == SQLiteErrorCode.Constraint)
                    {
                        // Handle the error gracefully, display an appropriate message to the user
                        MessageBox.Show("Data already exist!");
                    }
                    else
                    {
                        // Handle other SQLite exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    // Display error message in ComboBox
                    string msg = $"Insert Failed: {ex.Message}";
                    MessageBox.Show(msg);
                }
            }

        }

        private void Clear()
        {
            //txtActive.SelectedIndex = -1;
            cmbSession.SelectedIndex = -1;
            txtClasse.Texts = String.Empty;
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            // Initialize the database and add foreign key constraint
            dbCommands.InitializeDatabase();

            // Load data into the cmbSession dropdown
            LoadSessionData();

            // Load data into DataGridView with session names for the "Option" table
            // dbCommands.LoadDataIntoDataGridViewWithSession("Option", "Session", dataGridView1);
            LoadDataIntoDataGridViewWithSession("Option", dataGridView1);
        }

        private void LoadSessionData()
        {
            // Load data from the "Session" table into the cmbSession dropdown
            try
            {
                dbCommands.OpenConnection();

                string query = "SELECT * FROM Session";

                DataTable dataTable = dbCommands.GetDataForComboBox(query);

                // Assuming "Session" is the display member column, and "ID" is the value member column
                cmbSession.DisplayMember = "Session";
                cmbSession.ValueMember = "ID";
                cmbSession.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions or display an error message
                MessageBox.Show($"Failed to load Session data: {ex.Message}");
            }
            finally
            {
                dbCommands.CloseConnection();
            }
        }

        private void LoadDataIntoDataGridViewWithSession(string tableName, DataGridView dataGridView)
        {
            // Connect to the SQLite database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Query to retrieve the search results
                string query = $"SELECT Option.*, Session.Session AS Session FROM {tableName} " +
                           $"LEFT JOIN Session ON Option.SessionID = Session.ID";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Hide the SessionID column
                        dataTable.Columns["SessionID"].ColumnMapping = MappingType.Hidden;

                        dataGridView1.DataSource = dataTable;
                    }
                }

                connection.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                txtClasse.Texts = selectedRow.Cells["Option"].Value.ToString();

                // Get the value of the selected row's "AnneeAcademiqueId" column
                object selectedValue = selectedRow.Cells["Session"].Value;

                // Find the corresponding item in the ComboBox and select it
                foreach (DataRowView item in cmbSession.Items)
                {
                    if (item["Session"].Equals(selectedValue))
                    {
                        cmbSession.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            dbCommands.OpenConnection();

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Inserting data into table "Classe"
                DataRowView selectedRow = (DataRowView)cmbSession.SelectedItem;
                int sessionID = Convert.ToInt32(selectedRow["ID"]);
                string classe = txtClasse.Texts;

                // Retrieve the selected row index
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Update the corresponding row in the "AnneeAcademique" table
                int id = Convert.ToInt32(dataGridView1.Rows[selectedIndex].Cells["ID"].Value);

                Dictionary<string, object> columnValues = new Dictionary<string, object>
                {
                    { "Option", classe },
                    { "SessionID", sessionID },
                };
                dbCommands.EditData("Option", id, columnValues);
                dbCommands.CloseConnection();
                string message = "Edit Successfully!";
                dbCommands.ShowMessage(lblMessage, message, 3000);

                // Refresh the datagridview
                LoadDataIntoDataGridViewWithSession("Option", dataGridView1);
                Clear();
            }
        }

        private void btnNettoyer_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

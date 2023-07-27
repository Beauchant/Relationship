using Relationship.View;
using System.Data.SQLite;
using System.Reflection;

namespace Relationship
{
    public partial class Sessions : Form
    {
        static string connectionString = @"Data Source = Relationship.db";
        SQLiteDatabaseCommands dbCommands = new SQLiteDatabaseCommands(connectionString);
        public Sessions()
        {
            InitializeComponent();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            classes.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtAnneeAcademique.Texts == "" || cmbActive.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                try
                {
                    DateTime dateTime1 = Convert.ToDateTime(txtDateDebut.Text);
                    DateTime dateTime2 = Convert.ToDateTime(txtDateFin.Text);
                    string dateDebut = dateTime1.ToString("dd/MMM/yyyy");
                    string dateFin = dateTime2.ToString("dd/MMM/yyyy");

                    Models.AnneeAcademique anneeAcademique = new Models.AnneeAcademique(txtAnneeAcademique.Texts, dateDebut, dateFin, cmbActive.SelectedItem.ToString());
                    // Usage example
                    dbCommands.OpenConnection();

                    // Inserting data into "Table1"
                    Dictionary<string, object> columnValues1 = new Dictionary<string, object>
                {
                    { "Session", anneeAcademique._AnneeAcademique },
                    { "Start_Date", anneeAcademique.DateDebut },
                    { "End_Date", anneeAcademique.DateFin },
                    { "Active", anneeAcademique.Active },
                    // Add more column-value pairs as needed
                };

                    string message = "Add Successfully!";
                    dbCommands.InsertData("Session", columnValues1, lblMessage, message);
                    //dbCommands.ShowMessage(lblMessage, message, 3000);

                    dbCommands.CloseConnection();

                    dbCommands.GetAllData("Session", dataGridView1);

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
            cmbActive.SelectedIndex = -1;
            txtAnneeAcademique.Texts = String.Empty;
        }

        private void Sessions_Load(object sender, EventArgs e)
        {
            cmbActive.Items.Add("Yes");
            cmbActive.Items.Add("No");


            /// Initialize the database and add foreign key constraint
            dbCommands.InitializeDatabase();

            // Load data into DataGridView
            dbCommands.LoadDataIntoDataGridView("Session", dataGridView1);
        }
    }
}
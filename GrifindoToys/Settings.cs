using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class Settings : Form
    {
        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";
        // Home page referance
        public Form? homePage { get; set; }

        private Boolean isUpdateMode = false;

        public Settings()
        {
            InitializeComponent();
            txtNoOfLeaves.Focus();
        }

        private void loadSettings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "SELECT * FROM Setting";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve values from the database
                                int noOfLeaves = reader.GetInt32(0);
                                DateTime startDate = reader.GetDateTime(1);
                                DateTime endDate = reader.GetDateTime(2);
                                int dayCount = reader.GetInt32(3);

                                // Set values to text fields and date time pickers
                                txtNoOfLeaves.Text = noOfLeaves.ToString();
                                txtCycleDayCount.Text = dayCount.ToString();
                                pickCycleStartDate.Value = startDate;
                                pickCycleEndDate.Value = endDate;

                                isUpdateMode = true;
                                btnSave.Text = "Update";
                            }
                            else
                            {
                                //MessageBox.Show("No data found in the database.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve values from text fields and date time pickers
            int noOfLeaves = int.Parse(txtNoOfLeaves.Text);
            int dayCount = int.Parse(txtCycleDayCount.Text);
            DateTime startDate = pickCycleStartDate.Value;
            DateTime endDate = pickCycleEndDate.Value;

            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "";

                    if (isUpdateMode)
                    {
                        query = "UPDATE Setting SET noOfLeave = @leaves, " +
                            "cycleStartDate = @startDate, cycleEndDate = @endDate, salaryCycle = @dayCount";
                    }
                    else
                    {
                        query = "INSERT INTO Setting (noOfLeave, cycleStartDate, cycleEndDate, salaryCycle) " +
                                         "VALUES (@leaves, @startDate, @endDate, @dayCount)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@leaves", noOfLeaves);
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                        command.Parameters.AddWithValue("@dayCount", dayCount);

                        // Execute the SQL command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.loadSettings();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class User : Form
    {
        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";
        // Home page referance
        public Form? homePage { get; set; }
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            loadTableData();
            getNextUid();
        }

        private void loadTableData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT UID as 'User ID', username as 'Username' FROM Users";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void getNextUid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Users ORDER BY ID DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtUID.Text = "U-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtUID.Text = "U-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtUID.Text = "U-01";
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registerUser();
        }

        private void registerUser()
        {
            // Retrieve values from text fields
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string uid = txtUID.Text;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Users (UID, username, password) " +
                                         "VALUES (@uid, @username, @password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@uid", uid);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User Registration is successful.");
                        }
                        else
                        {
                            MessageBox.Show("User Registration fail.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }
            }
            clearForm();
            loadTableData();
            getNextUid();
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            comUID.Items.Clear();
            comUID.Visible = !comUID.Visible;
            txtUID.Visible = !txtUID.Visible;
            btnRegister.Enabled = checkSearch.Checked ? false : true;
            loadUserNameCombo();
        }
        private void loadUserNameCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT UID FROM Users";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    comUID.Items.Clear();
                    comUID.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        comUID.Items.Add(Dr["UID"]);
                    }
                    comUID.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            if (checkSearch.Checked)
            {
                comUID.SelectedIndex = 0;
            }
            else
            {
                comUID.Items.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtUsername.Text, Login.loginUserUsername))
            {
                MessageBox.Show("Can not delete login user from the system", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete User ID: " +
                comUID.Text + " record from the Database? ", "Confirm toDELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                string? selectedUid = comUID.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "DELETE FROM Users WHERE UID=@uid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@uid", selectedUid);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User Delete is successful.");
                            }
                            else
                            {
                                MessageBox.Show("User Delete fail.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                clearForm();
                loadTableData();
                getNextUid();
            }
        }

        private void comUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comUID.SelectedIndex > 0)
            {
                string? selectedUid = comUID.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Users WHERE UID=@uid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@uid", selectedUid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtUsername.Text = reader.GetString(2);
                                    txtPassword.Text = reader.GetString(3);
                                }
                                else
                                {
                                    MessageBox.Show("No data found in the database.");
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
            else { clearForm(); }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

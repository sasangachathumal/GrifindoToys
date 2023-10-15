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
using System.Xml.Linq;

namespace GrifindoToys
{
    public partial class Employee : Form
    {
        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";
        // Home page referance
        public Form? homePage { get; set; }
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            txtEID.Focus();
            loadTableData();
            getNextEid();
        }

        private void getNextEid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT TOP 1 ID FROM Employee ORDER BY ID DESC";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int lastID = reader.GetInt32(0);
                                if (lastID < 10)
                                {
                                    txtEID.Text = "E-0" + (lastID += 1);
                                }
                                else
                                {
                                    txtEID.Text = "E-" + (lastID += 1);
                                }
                            }
                            else
                            {
                                txtEID.Text = "E-01";
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

        private void loadTableData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT EID as 'Employee ID', name as 'Name', nic as 'NIC'," +
                        " mSalary as 'Month Salary', otRate as 'OT Rate', allowance as 'Allowance' FROM Employee";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgEmployee.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (checkSearch.Checked)
            {
                updateEmployee();
            }
            else
            {
                registerEmployee();
            }
        }

        private void registerEmployee()
        {
            // Retrieve values from text fields
            string name = txtEName.Text;
            string nic = txtNIC.Text;
            string eid = txtEID.Text;
            double salary, otRate, allowance;

            if (!double.TryParse(txtMSalary.Text, out salary) ||
                !double.TryParse(txtOTRate.Text, out otRate) ||
                !double.TryParse(txtAllowance.Text, out allowance))
            {
                MessageBox.Show("Invalid values in Salary or Allowance or OT Rate.", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Employee (EID, name, nic, mSalary, otRate, allowance) " +
                                         "VALUES (@eid, @name, @nic, @salary, @otRate, @allowance)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@eid", eid);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@nic", nic);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@otRate", otRate);
                        command.Parameters.AddWithValue("@allowance", allowance);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee Registration is successful.");
                        }
                        else
                        {
                            MessageBox.Show("Employee Registration fail.");
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
            getNextEid();
        }

        private void updateEmployee()
        {
            // Retrieve values from text fields
            string? name = comEID.SelectedItem.ToString();
            string nic = txtNIC.Text;
            string eid = txtEID.Text;
            double salary, otRate, allowance;

            if (!double.TryParse(txtMSalary.Text, out salary) ||
                !double.TryParse(txtOTRate.Text, out otRate) ||
                !double.TryParse(txtAllowance.Text, out allowance))
            {
                MessageBox.Show("Invalid values in Salary or Allowance or OT Rate.", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to update data
                    string updateQuery = "UPDATE Employee SET name = @name, " +
                                         "NIC = @nic, mSalary = @salary, otRate = @otRate, " +
                                         "allowance = @allowance " +
                                         "WHERE ID = @eid";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@nic", nic);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@otRate", otRate);
                        command.Parameters.AddWithValue("@allowance", allowance);
                        command.Parameters.AddWithValue("@eid", eid);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee Update is successful.");
                        }
                        else
                        {
                            MessageBox.Show("Employee Update fail.");
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
        }

        private void checkSearch_CheckedChanged(object sender, EventArgs e)
        {
            comEID.Items.Clear();
            comEID.Visible = !comEID.Visible;
            btnRegister.Text = checkSearch.Checked ? "Update" : "Register";
            txtEID.Visible = !txtEID.Visible;
            loadEmployeeIDCombo();
            comEID.Focus();
        }

        private void loadEmployeeIDCombo()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT EID FROM Employee";
                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    comEID.Items.Clear();
                    comEID.Items.Add("--SELECT--");
                    foreach (DataRow Dr in dt.Rows)
                    {
                        comEID.Items.Add(Dr["EID"]);
                    }
                    comEID.SelectedIndex = 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void clearForm()
        {
            txtAllowance.Text = string.Empty;
            txtEName.Text = string.Empty;
            txtMSalary.Text = string.Empty;
            txtNIC.Text = string.Empty;
            txtOTRate.Text = string.Empty;
            if (checkSearch.Checked)
            {
                comEID.SelectedIndex = 0;
            }
            else
            {
                comEID.Items.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void comEID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comEID.SelectedIndex > 0)
            {
                string? selectedEid = comEID.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Employee WHERE EID=@eid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@eid", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtEName.Text = reader.GetString(2);
                                    txtNIC.Text = reader.GetString(3);
                                    txtMSalary.Text = reader.GetDecimal(4).ToString();
                                    txtOTRate.Text = reader.GetDecimal(5).ToString();
                                    txtAllowance.Text = reader.GetDecimal(6).ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaRes = MessageBox.Show("Are you sure, You want to Delete Employee ID: " +
                comEID.Text + " record from the Database? ", "Confirm toDELETE!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diaRes == DialogResult.Yes)
            {
                string? selectedEid = comEID.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "DELETE FROM Employee WHERE EID=@eid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@eid", selectedEid);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee Delete is successful.");
                            }
                            else
                            {
                                MessageBox.Show("Employee Delete fail.");
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
            }
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.TextLength == 10 || txtNIC.TextLength == 12)
            {
                txtNIC.ForeColor = Color.Green;
            }
            else
            {
                txtNIC.ForeColor = Color.Red;
            }
        }

        private void txtMSalary_TextChanged(object sender, EventArgs e)
        {
            if (txtMSalary.TextLength > 11)
            {
                txtMSalary.ForeColor = Color.Red;
            }
            else
            {
                txtMSalary.ForeColor = Color.Green;
            }
        }

        private void txtAllowance_TextChanged(object sender, EventArgs e)
        {
            if (txtAllowance.TextLength > 11)
            {
                txtAllowance.ForeColor = Color.Red;
            }
            else
            {
                txtAllowance.ForeColor = Color.Green;
            }
        }

        private void txtOTRate_TextChanged(object sender, EventArgs e)
        {
            if (txtOTRate.TextLength > 11)
            {
                txtOTRate.ForeColor = Color.Red;
            }
            else
            {
                txtAllowance.ForeColor = Color.Green;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

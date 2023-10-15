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
    public partial class Salary : Form
    {
        // DB Connection String
        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";
        // Home page referance
        public Form? homePage { get; set; }

        // Settings Details
        private Setting? setting = new Setting();

        // Employee Details
        private EmployeeModel? employee = new EmployeeModel();

        public Salary()
        {
            InitializeComponent();
            loadEmployeeIDCombo();
            comEID.Focus();
        }

        // Load employee EID to combobox comEID
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

        // Clear the all fields in form
        private void clearForm()
        {
            txtAllowance.Text = string.Empty;
            txtEName.Text = string.Empty;
            txtMSalary.Text = string.Empty;
            txtENIC.Text = string.Empty;
            txtOTRate.Text = string.Empty;
            comEID.SelectedIndex = 0;

            txtNoOfAbsents.Text = string.Empty;
            txtNoOfHolidays.Text = string.Empty;
            txtNoOfLeaves.Text = string.Empty;
            txtOTHours.Text = string.Empty;

            txtBasePay.Text = string.Empty;
            txtGrossPay.Text = string.Empty;
            txtNoPay.Text = string.Empty;

            pickEndDate.Value = DateTime.Now;
            pickStartDate.Value = DateTime.Now;
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
                                    txtENIC.Text = reader.GetString(3);
                                    txtMSalary.Text = reader.GetDecimal(4).ToString();
                                    txtOTRate.Text = reader.GetDecimal(5).ToString();
                                    txtAllowance.Text = reader.GetDecimal(6).ToString();

                                    employee = new EmployeeModel(reader.GetInt32(0), selectedEid, reader.GetString(2), reader.GetString(3),
                                        double.Parse(reader.GetDecimal(4).ToString()), double.Parse(reader.GetDecimal(4).ToString()),
                                        double.Parse(reader.GetDecimal(4).ToString()));
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

        private void btnCalSalary_Click(object sender, EventArgs e)
        {
            getSettings();
            calculateSalary();
        }

        // This method for calculate the salary of employee
        private void calculateSalary()
        {
            if (isDateValid() && isTextFieldsValid())
            {
                // Get text filed data
                //int noOfLeaves = int.Parse(txtNoOfLeaves.Text);
                //int noOfHolidays = int.Parse(txtNoOfHolidays.Text);

                // Calculate Base Salary
                if (calculateBaseSalary())
                {
                    // Calculate No Pay Amount
                    calculateNoPayAmount();

                    // Calculate Gross Salary
                    calculateGrossSalary();
                }
            }
            else
            {
                return;
            }
        }

        private void calculateGrossSalary()
        {
            double basePay, noPay, grossPay, taxAmount;
            double taxRate = txtTaxRate.Text == null ? 0 : double.Parse(txtTaxRate.Text.Replace("%", "")) / 100;
            // check text input can convert to int or double
            if (!double.TryParse(txtNoPay.Text, out noPay) ||
                !double.TryParse(txtBasePay.Text, out basePay))
            {
                MessageBox.Show("Invalid values in Base Pay or No Pay.", "Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            taxAmount = taxRate != 0 ? basePay * taxRate : 0;
            grossPay = basePay - (noPay + taxAmount);
            txtGrossPay.Text = grossPay.ToString("F");
            txtTaxAmount.Text = taxAmount.ToString("F");
        }

        private Boolean calculateBaseSalary()
        {
            try
            {
                int otHours = int.Parse(txtOTHours.Text);
                double salary = double.Parse(txtMSalary.Text);
                double otRate = double.Parse(txtOTRate.Text);
                double allowance = double.Parse(txtAllowance.Text);
                double basePay;

                basePay = salary + allowance + (otHours * otRate);
                txtBasePay.Text = basePay.ToString("F");
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void calculateNoPayAmount()
        {
            int extraLeaves = 0;
            int cycleDayCount = 0;
            int noOfAbsent = txtNoOfAbsents.Text == null ? 0 : int.Parse(txtNoOfAbsents.Text);
            int noOfHolidays = txtNoOfHolidays.Text == null ? 0 : int.Parse(txtNoOfHolidays.Text);
            double salary = double.Parse(txtMSalary.Text);

            // check setting object before code logic
            if (setting == null)
            {
                MessageBox.Show("Issue occurred while retrieving settings data \n Please close the window and revisit",
                    "Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check employee took more leaves
            if (setting.getNoOfLeaves() < int.Parse(txtNoOfLeaves.Text))
            {
                extraLeaves = int.Parse(txtNoOfLeaves.Text) - setting.getNoOfLeaves();
            }

            // add extra leaves and absents
            noOfAbsent += extraLeaves;

            // calculate cycle day count
            cycleDayCount = setting.getCycleDayCount() - noOfHolidays;

            if (noOfAbsent > 0)
            {
                double noPayAmount = (salary / cycleDayCount) * noOfAbsent;
                txtNoPay.Text = noPayAmount.ToString("F");
            }
        }

        // Check input data is valid or not
        private Boolean isTextFieldsValid()
        {
            int tempI = 0;
            double tempD = 0;
            string tempAbsent = txtNoOfAbsents.Text == null ? "0" : txtNoOfAbsents.Text;

            if (!int.TryParse(txtOTHours.Text, out tempI) ||
                !double.TryParse(txtMSalary.Text, out tempD) ||
                !double.TryParse(txtOTRate.Text, out tempD) ||
                !double.TryParse(txtAllowance.Text, out tempD) ||
                !int.TryParse(tempAbsent, out tempI))
            {
                MessageBox.Show("Invalid values in text fileds.\n Please check you\'r input values.", "Invalid input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Validate selected dates
        private Boolean isDateValid()
        {
            DateTime startDate = pickStartDate.Value;
            DateTime endDate = pickEndDate.Value;

            // check setting object before code logic
            if (setting == null)
            {
                MessageBox.Show("Issue occurred while retrieving settings data \n Please close the window and revisit",
                    "Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(startDate.Date >= setting?.getCycleStartDate().Date))
            {
                MessageBox.Show("Please select valid date to \'Start Date\'",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!(endDate.Date <= setting.getCycleEndDate().Date))
            {
                MessageBox.Show("Please select valid date to \'End Date\'",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Get settings data from DB
        private void getSettings()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Create an SQL command to insert data into a table
                    string selectQuery = "SELECT * FROM Setting";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.setting = new Setting();

                                setting.setCycleStartDate(reader.GetDateTime(1));
                                setting.setCycleEndDate(reader.GetDateTime(2));
                                setting.setNoOfLeaves(reader.GetInt32(0));
                                setting.setCycleDayCount(reader.GetInt32(3));

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

        private void btnSave_Click(object sender, EventArgs e)
        {

            // check setting object before code logic
            if (employee == null)
            {
                MessageBox.Show("Issue occurred while retrieving employee data \n Please select the employee again or close the window and revisit",
                    "Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve values from text fields
            string name = txtEName.Text;
            int noOfLeaves, noOfAbsent, noOfHolidays, otHours;
            double baseSalary, grossSalary, noPay, taxAmount;

            if (!double.TryParse(txtNoPay.Text, out noPay) ||
                !double.TryParse(txtBasePay.Text, out baseSalary) ||
                !double.TryParse(txtGrossPay.Text, out grossSalary) ||
                !double.TryParse(txtTaxAmount.Text, out taxAmount))
            {
                MessageBox.Show("Invalid values in Salary or Allowance or OT Rate.", "Invalid Values",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            noOfLeaves = txtNoOfLeaves.Text != string.Empty ? int.Parse(txtNoOfLeaves.Text) : 0;
            noOfAbsent = txtNoOfAbsents.Text != string.Empty ? int.Parse(txtNoOfAbsents.Text) : 0;
            noOfHolidays = txtNoOfHolidays.Text != string.Empty ? int.Parse(txtNoOfHolidays.Text) : 0;
            otHours = txtOTHours.Text != string.Empty ? int.Parse(txtOTHours.Text) : 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create an SQL command to insert data into a table
                    string insertQuery = "INSERT INTO Salary (EID, baseSalary, grossSalary, noPayAmount, date, noOfLeaves, noOfAdsent" +
                        ", noOfHolidays, otHours, taxAmount) VALUES (@eid, @bSalary, @gSalary, @noPay, @date, @noOfLeaves, @noOfAbsent," +
                        "@noOfHolidays, @otHours, @taxAmount)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@eid", employee.ID);
                        command.Parameters.AddWithValue("@bSalary", baseSalary);
                        command.Parameters.AddWithValue("@gSalary", grossSalary);
                        command.Parameters.AddWithValue("@noPay", noPay);
                        command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                        command.Parameters.AddWithValue("@noOfLeaves", noOfLeaves);
                        command.Parameters.AddWithValue("@noOfAbsent", noOfAbsent);
                        command.Parameters.AddWithValue("@noOfHolidays", noOfHolidays);
                        command.Parameters.AddWithValue("@otHours", otHours);
                        command.Parameters.AddWithValue("@taxAmount", taxAmount);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Salary calculation saving is successful.");
                            clearForm();
                        }
                        else
                        {
                            MessageBox.Show("Salary calculation saving fail.");
                        }
                    }
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            SalaryReport salaryReport = new SalaryReport();
            salaryReport.ShowDialog();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

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
    public partial class SalaryReport : Form
    {

        private const string connectionString = "Data Source=SMSC-DESKTOP-PC;Initial Catalog=Grifindo_Toys;Integrated Security=True";
        // Home page referance
        public Form? homePage { get; set; }

        // Employee Details
        private EmployeeModel? employee = new EmployeeModel();

        public SalaryReport()
        {
            InitializeComponent();
            comEID.Focus();
        }

        private void SalaryReport_Load(object sender, EventArgs e)
        {
            loadEmployeeIDCombo();
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

        private void comEID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check combo box selected index more that 0
            if (comEID.SelectedIndex > 0)
            {
                //get selected item
                string? selectedEid = comEID.SelectedItem.ToString();
                // create sql connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        // open connection
                        connection.Open();

                        // Create an SQL command to insert data into a table
                        string selectQuery = "SELECT * FROM Employee WHERE EID=@eid";

                        using (SqlCommand command = new SqlCommand(selectQuery, connection))
                        {
                            // passvalues to query
                            command.Parameters.AddWithValue("@eid", selectedEid);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                // check any thing return
                                if (reader.Read())
                                {
                                    
                                    txtEName.Text = reader.GetString(2);
                                    // assign data to employee object
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

        private void clearForm()
        {
            comEID.SelectedIndex = 0;
            txtEName.Text = string.Empty;
            pickEndDate.Value = DateTime.Now;
            pickStartDate.Value = DateTime.Now;
            checkEAll.Checked = false;
            checkDateRange.Checked = false;
            dgSalary.DataSource = null;
        }

        private void checkEAll_CheckedChanged(object sender, EventArgs e)
        {
            comEID.Enabled = !checkEAll.Checked;
            txtEName.Visible = !checkEAll.Checked;
            lblEname.Visible = !checkEAll.Checked;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void checkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            lblEndDate.Visible = checkDateRange.Checked;
            pickEndDate.Visible = checkDateRange.Checked;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // check setting object before code logic
            if (employee == null)
            {
                MessageBox.Show("Issue occurred while retrieving employee data \n " +
                    "Please select the employee again or close the window and revisit",
                    "Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // split querry to parts
            string query = "";
            string queryStart = "SELECT Employee.name as 'Employee Name', Employee.EID as 'Employee ID', " +
                "Salary.baseSalary as 'Base Salary', Salary.grossSalary as 'Gross Salary', Salary.noPayAmount as 'No Pay Amount', " +
                "Salary.date as 'Pay Date'" +
                "FROM Employee " +
                "LEFT JOIN Salary ON Employee.ID = Salary.EID ";
            string queryEnd = " ORDER BY Salary.date";
            string queryWhere = "WHERE ";
            string queryWhereEmp = "";
            string queryWhereDate = "";

            // check All Employee selected or not and update query
            if (!checkEAll.Checked)
            {
                queryWhereEmp += "Employee.ID =" + employee.ID;
            }
            else
            {
                queryWhereEmp = string.Empty;
            }
            // check date range selected or not and update query
            if (checkDateRange.Checked)
            {
                DateTime startDate = pickStartDate.Value;
                DateTime endDate = pickEndDate.Value;
                queryWhereDate += "Salary.date BETWEEN '" + startDate.Date + "' AND '" + endDate.Date + "'";
            }
            else
            {
                DateTime selectedDate = pickStartDate.Value;
                DateTime startDate = new DateTime(selectedDate.Year, selectedDate.Month, 1);
                DateTime endDate = startDate.AddMonths(1).AddDays(-1);

                queryWhereDate += "Salary.date BETWEEN '" + startDate.Date + "' AND '" + endDate.Date + "'";
            }

            // combine query parts and create full query

            if (!checkEAll.Checked)
            {
                queryWhere += queryWhereEmp + " AND " + queryWhereDate;
            }
            else
            {
                queryWhere += queryWhereDate;
            }

            query = queryStart + queryWhere + queryEnd;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable dt = new DataTable();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                    dgSalary.DataSource = null;
                    dgSalary.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            homePage?.Show();
        }
    }
}

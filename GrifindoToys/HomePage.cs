using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrifindoToys
{
    public partial class HomePage : Form
    {
        public Form? loginPage { get; set; }
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.homePage = this;
            settings.Show();
            this.Hide();
        }

        private void lblSalaryReport_Click(object sender, EventArgs e)
        {
            SalaryReport salaryReport = new SalaryReport();
            salaryReport.homePage = this;
            salaryReport.Show();
            this.Hide();
        }

        private void lblSalaryCal_Click(object sender, EventArgs e)
        {
            Salary salary = new Salary();
            salary.homePage = this;
            salary.Show();
            this.Hide();
        }

        private void lblEmployeeManage_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.homePage = this;
            employee.Show();
            this.Hide();
        }

        private void lblUserManage_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.homePage = this;
            user.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult resEx = MessageBox.Show("Are you sure, You want to Logout?",
                "Confirm to Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resEx == DialogResult.Yes)
            {
                this.Close();
                loginPage?.Show();
            }
        }
    }
}

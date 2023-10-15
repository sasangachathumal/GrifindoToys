using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrifindoToys
{
    internal class EmployeeModel
    {
        public int ?ID { get; set; }
        public string ?EID { get; set; }
        public string ?name { get; set; }
        public string ?nic { get; set; }
        public double ?mSalary { get; set; }
        public double ?otRate { get; set; }
        public double ?allowance { get; set; }

        public EmployeeModel(int iD, string ?eID, string name, string nic, double mSalary, double otRate, double allowance)
        {
            ID = iD;
            EID = eID;
            this.name = name;
            this.nic = nic;
            this.mSalary = mSalary;
            this.otRate = otRate;
            this.allowance = allowance;
        }

        public EmployeeModel()
        {
        }
    }
}

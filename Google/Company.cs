using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Company
    {
        //<companyName> <department> <salary>
        public string CompanyName { get; set; } = "";
        public string Department { get; set; } = "";
        public decimal Salary { get; set; } = 0m;

        public Company(string companyName, string department, decimal salary)
        {
            this.CompanyName = companyName;
            this.Department = department;
            this.Salary = salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.FactoryDesignPattern
{
    public class PartTimeEmployee : IEmployee
    {
        public string EmployeeType()
        {
            return "PartTime";
        }

        public string GetSalary()
        {
            return "PartTime Employee's Salary : 10000";
        }
    }
}

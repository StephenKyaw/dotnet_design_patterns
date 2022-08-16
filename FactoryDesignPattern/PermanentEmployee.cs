using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class PermanentEmployee : IEmployee
    {
        public string EmployeeType()
        {
            return "Permanent";
        }

        public string GetSalary()
        {
            return "Permanent Employee's Salary : 15000";
        }
    }
}

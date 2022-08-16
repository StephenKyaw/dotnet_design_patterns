using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.FactoryDesignPattern
{
    public class PermanentEmployeem : IEmployee
    {
        public string EmployeeType()
        {
            return "Permanent";
        }

        public string GetSalary()
        {
            return "Permanent Employee's Salary : 20000";
        }
    }
}

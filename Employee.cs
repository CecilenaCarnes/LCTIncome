using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCTIncome
{
    public class Employee
    {
        public string Name;
        public string Dependents;

        public string getData()
        {
            return this.Name + " has " + this.Dependents + " dependents";
        }
    }
}

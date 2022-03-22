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
        public string Title;

        public string getData()
        {
            return this.Name +", "+ this.Title + " has " + this.Dependents + " dependents";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace LCTIncome
{
    class Program

   

    {
        static void Main(string[] args)
        {
            Header();
            Console.ReadLine();

            Date();
            Console.ReadLine();

            Line();
            
           //This goes with the Employee.cs which is defining the class Employee
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(new Employee());
            lstEmployees[0].Name = "Lucas Carnes";
            lstEmployees[0].Dependents = "0";
            lstEmployees[0].Title = "Owner";

            lstEmployees.Add(new Employee());
            lstEmployees[1].Name = "John Davidson";
            lstEmployees[1].Dependents = "2";
            lstEmployees[1].Title = "Employee";

            foreach (Employee emp in lstEmployees)  
            {
                Console.WriteLine(emp.getData());
            }

            Line();
            Console.ReadLine();

                double totalIncome = 0;
                double[] income;
                string answer = "";

            do
            {
                Console.WriteLine("Enter total income - whole numbers only - no decimals ");
                totalIncome = Convert.ToInt32(Console.ReadLine());
                //double income = totalIncome;--I don't know when this was added but it doesn't like it.
                double payroll = totalIncome * .20;
                double truckPmt = 220.30;
                double fuel = totalIncome * .30;
                double expenses = totalIncome * .10;
                double selfEmploymentTax = totalIncome * .30;
                double profit = Math.Floor(totalIncome - (payroll + truckPmt + fuel + expenses + selfEmploymentTax));

                Console.WriteLine();
                Console.WriteLine("Total Income PayPeriod $" + ((double)totalIncome));
                Console.WriteLine();
                Console.WriteLine("Payroll:                   " + (payroll));
                Console.WriteLine("Truck Payment:             " + (truckPmt));
                Console.WriteLine("Fuel:                      " + (fuel));
                Console.WriteLine("Expense Allocation:        " + (expenses));
                Console.WriteLine("Self Employment Taxes:     " + (selfEmploymentTax));
                Console.WriteLine("Profit:                    " + (profit));

                Console.WriteLine("Would you like to enter another income amount?  Yes or No");
                answer = Console.ReadLine();
            } while (answer == "Yes"); 

        }

        public static void Header()
        {
            Console.WriteLine("Luke Carnes Trucking, LLC | Barbourville, KY | 606.546.8606 | lukecarnestrucking@gmail.com");

        }

        public static void Date()
        {
           DateTime date = DateTime.Now;
           Console.WriteLine(date.ToString("D"));
        }

        public static void Line()
        {
            Console.WriteLine("******************************");
        }
    }

}
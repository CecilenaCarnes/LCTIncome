using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LCTIncome
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Luke Carnes Trucking, LLC");

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("D"));

            //This goes with the Employee.cs which is defining the class Employee
            List<Employee> lstEmployees = new List<Employee>();
            lstEmployees.Add(new Employee());
            lstEmployees[0].Name = "Lucas Carnes";
            lstEmployees[0].Dependents = "0";

            lstEmployees.Add(new Employee());
            lstEmployees[1].Name = "John Davidson";
            lstEmployees[1].Dependents = "2";

            foreach (Employee emp in lstEmployees)  
            {
                Console.WriteLine(emp.getData());
            }
            Console.ReadLine();
            
 

                int totalIncome = 0;
                double[] income;

               

                Console.WriteLine("Enter total income ");
                totalIncome = Convert.ToInt32(Console.ReadLine());

                income = new double[totalIncome];
                double payroll = totalIncome * .20;
                double truckPmt = 220.30;
                double fuel = totalIncome * .30;
                double expenses = totalIncome * .10;
                double selfEmploymentTax = totalIncome * .30;
                double profit = totalIncome - (payroll + truckPmt + fuel + expenses + selfEmploymentTax);

                Console.WriteLine("Total Income PayPeriod $"+(double)totalIncome);
                Console.WriteLine("Payroll:                   " + (payroll));
                Console.WriteLine("Truck Payment:             " + (truckPmt));
                Console.WriteLine("Fuel:                      " + (fuel));
                Console.WriteLine("Expense Allocation:        " + (expenses));
                Console.WriteLine("Self Employment Taxes:     " + (selfEmploymentTax));
                Console.WriteLine("Profit:                    " + (profit));






 





            /*Console.WriteLine("Enter Name:");

            string userName = Console.ReadLine();


            Console.WriteLine("Username is: {0}!", userName);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();*/

        }
    }

}
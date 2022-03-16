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
            /*Console.WriteLine("Enter Name:");

            string userName = Console.ReadLine();


            Console.WriteLine("Username is: {0}!", userName);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();*/

        }
    }

}
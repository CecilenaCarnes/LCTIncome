using System;


namespace NameInput
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("Luke Carnes Trucking, LLC");

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("D"));


            Console.WriteLine("Enter Name:");

            string userName = Console.ReadLine();


            Console.WriteLine("Username is: {0}!", userName);

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }

}
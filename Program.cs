using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Luke Carnes Trucking, LLC" );
//can I calculate the date to put in the write line//

//enter employees - one owner O - others are employees E
//distinguish between two//
//owner gets different calculations than employees//
//Class would be People
//Object would be owner and employees


class People
{
    string name1 = "Luke";
    string name2 = "David";
   private static void Main(string[] args)
    {
        People myObj1 = new People();
        People myObj2 = new People();
        Console.WriteLine(myObj1.name1);
        Console.WriteLine(myObj2.name2);
    }
    }
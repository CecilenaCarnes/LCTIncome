LCTIncome
	Luke Carnes Trucking, LLC - Income Allocation Calculation
		This app is used to return current employees and calculate a set a data points from the main entry of gross income (Total Income).
	
	Instructions to Run
		Built in VS 2022 
		Requires any key entry to return after the console returns employee list.  Instructions say use enter key.
		You are prompted to enter the Total Income.  This is expecting a whole number with no $ or decimal.
 
	
	Requirement List
		Git Hub Commits - DONE
		Readme File - DONE
		One Class with One Object that you populate data then use or display.
			Classes = Employee & Payroll
			Objects = Name, Title and Dependants
			These are displayed on the screen before you input the Gross Income Amount

		Create and call 3 functions or methods. 1 must return a value that is used in the application.
			In Class.cs getData() function. - Retrieves to write the Employee and Payroll data.
			In Program.cs ToString() method is used in returning the date.
			In Program.cs Console.ReadLine() and Console.WriteLine() used throughout.
			In Program.cs Convert.ToInt32(Console.Readline()) 


		Choose 3 from Feature List.
			Master Loop - Enter to move forward. Enter Income value for calculation.  
			Additional Class which inherits from other.  Payroll contains title and dependents but I am calling it from Employee.
			List - Displays the List of Employees, Title and number of Dependants.
			Calculate and Display Data - External input is user input and various calculations to arrive at payroll, tax, expense.


		Additional Items.
			For Each Loop - Writes each employees data from the list with their name, title and dependents.
			Math.Floor to remove decimal values from Profit calculation.

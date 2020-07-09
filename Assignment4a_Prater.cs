/* Brie Prater
06/26/2020
CIS 353
Professor Cain
Assignment 4.2 A */

using System;
namespace CIS353
{
	public class Date // creating public class Date
	{
		int month; // variable to hold month
		int day; // variable to hold day
		int year; // variable to hold year
		public Date() // Date constructor with no arguments
		{
			month = 1; // preset is assigned to variables
			day = 1;
			year = 2000;
			Console.WriteLine("Using no-argument constructor with assigned date: ");
		}
		public Date(int argMonth, int argDay) // Date constructor with two arguments
		{
			month = argMonth; // allows for user input
			day = argDay; // enables user input to be displayed later
			year = 2004; // preset is assigned to variable
			Console.WriteLine("Using 2-argument constructor with assigned year: ");
		}
		public Date(int argMonth, int argDay, int argYear) // Date constructor with three arguments
		{
			month = argMonth; // allows for user input
			day = argDay; // sets user input to variables
			year = argYear; // enables user input to be displayed later
			Console.WriteLine("Using 3-argument constructor: ");
		}
		public void DisplayIt() // DisplayIt method to display date in the object
		{
			Console.WriteLine("The date in this object is {0}/{1}/{2}", month, day, year);
		}
	}
	public class Test
	{
		public static void Main(string[] args) // Main method
		{
			Console.WriteLine("********************");
			Date one = new Date(); // instantiates Date with no arguments
			one.DisplayIt(); // calls DisplayIt method for one constructor
			Console.WriteLine("********************");
			Console.WriteLine("Please enter a month using an integer (ex: use 3 for March): ");
			int x = Convert.ToInt32(Console.ReadLine()); //sets user input to variable
			Console.WriteLine("Please enter a day using an integer (ex: 10): ");
			int y = Convert.ToInt32(Console.ReadLine()); // sets user input to variable
			Date two = new Date(x, y); // instantiates Date and passes two variables
			two.DisplayIt(); // calls DisplayIt method for two constructor
			Console.WriteLine("********************");
			Console.WriteLine("Please enter a month using an integer (ex: use 3 for March): ");
			int a = Convert.ToInt32(Console.ReadLine()); // sets user input to variable
			Console.WriteLine("Please enter a day using an integer (ex: 10): ");
			int b = Convert.ToInt32(Console.ReadLine()); // sets user input to variable
			Console.WriteLine("Please enter a year using integers (ex: 1990): ");
			int c = Convert.ToInt32(Console.ReadLine()); // sets user input to variable
			Date three = new Date(a, b, c); // instantiates Date and passes three variables
			three.DisplayIt(); // calls DisplayIt for three constructor
		}
	}
}
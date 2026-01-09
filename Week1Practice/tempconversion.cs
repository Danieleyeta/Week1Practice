using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
	internal class tempconversion
	{
		public static void Run()
		{
			string userChoice;
			double userTemp;
			double userResult = 0;

			Console.WriteLine("Would you like to convert from Fahrenheit to Celsius (F) or Celsius to Fahrenheit (C)?");
			userChoice = Console.ReadLine().ToUpper();
			Console.WriteLine("Please enter the temperature you would like to convert:");

			userTemp = double.Parse(Console.ReadLine());

			if (userChoice == "F")
			{
				userResult = (userTemp - 32) * 5 / 9;
				Console.WriteLine($"{userTemp} degrees Fahrenheit is equal to {userResult} degrees Celsius.");
			} else if (userChoice == "C")
			{
				userResult = (userTemp - 32) * 9 / 5 + 32;
				Console.WriteLine($"{userTemp} degrees Celsius is equal to {userResult} degrees Fahrenheit.");
			} else
			{
				Console.WriteLine("Invalid choice");
			}
		} } }


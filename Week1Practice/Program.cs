using System;
using Week1Practice; // <--- THIS LINE FIXES THE CALCULATOR ERROR

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Temperature Converter");
        Console.WriteLine("3. Age Calculator");
        Console.WriteLine("4 Grade Calculator");
        Console.WriteLine("5. Using Switch Statement for grade scoring");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Calculator.Run();
        }
        else if (choice == "2")
        {
            tempconversion.Run();
            
        }else if (choice == "3")
        {
             AgeCalculator.Run();
        }else if (choice == "4")
        {
             gradeCalculator.Run();
        }
        else if (choice == "5")
        {
            usingswitchstatement.Run();
        }
        Console.WriteLine("\nPress Enter to close...");
        Console.ReadLine();
    
}
}
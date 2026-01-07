using System;
using Week1Practice; // <--- THIS LINE FIXES THE CALCULATOR ERROR

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a program to run:");
        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Temperature Converter (Coming Soon)");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Calculator.Run();
        }
        else if (choice == "2")
        {
            // TempConverter.Run(); // <--- COMMENTED OUT UNTIL YOU CREATE THE FILE
            Console.WriteLine("You haven't built this yet!");
        }
    }
}
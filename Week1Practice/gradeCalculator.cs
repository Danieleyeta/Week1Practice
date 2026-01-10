using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    internal class gradeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Enter your scorce(0-100)");
            string scoreInput = Console.ReadLine();
            int score = Convert.ToInt32(scoreInput);
            if (score >= 70)
            {
                Console.WriteLine("You have passed the exam, You got 'A'");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You have passed the exam, You got 'B'");
            }
            else if (score >= 50)
            {
                Console.WriteLine("You have passed the exam, You got 'C'");
            }
            else if (score >= 40)
            {
                Console.WriteLine("You have passed the exam, You got 'D'");
            }
            else
            {
                Console.WriteLine("You have failed the exam, You got 'F'");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    internal class usingswitchstatement
    {
        public static void Run()
        {
            Console.WriteLine("Enter your scorce(0-100)");
            string scoreInput = Console.ReadLine();
            int score = Convert.ToInt32(scoreInput);

            switch (score){
                case var s when s >= 70:
                    Console.WriteLine("You have passed the exam, You got 'A'");
                    break;
                case var s when s >= 60:
                    Console.WriteLine("You have passed the exam, You got 'B'");
                    break;
                case var s when s >= 50:
                    Console.WriteLine("You have passed the exam, You got 'C'");
                    break;
                case var s when s >= 40:
                    Console.WriteLine("You have passed the exam, You got 'D'");
                    break;
                default:
                    Console.WriteLine("You have failed the exam, You got 'F'");
                    break;
            }

        }
    }
}
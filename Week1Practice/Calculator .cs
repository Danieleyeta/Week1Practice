using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    internal class Calculator
    {
        public static void Run()
        {

            Console.WriteLine("Input first number");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            Console.WriteLine("input second number");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            int addition = num1 + num2;
            Console.WriteLine("the addition is" + addition);

        }
    }
}

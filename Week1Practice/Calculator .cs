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
            string total;

            Console.WriteLine("Input first number");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            Console.WriteLine("input second number");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);


            Console.WriteLine("what operation do you want to perform? Addition, Substraction, Division, Multiplication(A, S, D, M)");
            total = Console.ReadLine().ToUpper();

            if (total == "A")
            {
                int addition = num1 + num2;
                Console.WriteLine("the addition is " + addition);
            }
            else if (total == "S")
            {
                int substraction = num1 - num2;
                Console.WriteLine("the substraction is " + substraction);
            }
            else if (total == "D")
            {
                int division = num1 / num2;
                Console.WriteLine("the division is " + division);

            }
            else if (total == "M")
            {
                int multiplication = num1 * num2;
                Console.WriteLine("the multiplication is " + multiplication);
            }

        }   
    }
}

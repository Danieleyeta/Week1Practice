using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Practice
{
    internal class AgeCalculator
    {
        public static void Run()
        {


            Console.WriteLine("Enter Your Birth Year");
            string birthYearInput = Console.ReadLine();
            int birthYear = Convert.ToInt32(birthYearInput);
            Console.WriteLine($"You are {2026 - birthYear} years old.");
        } } }
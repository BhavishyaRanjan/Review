using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Calculate_Average_of_Three_Numbers
    {
        static void AverageThree()
        {
            Console.Write("Enter First Number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double avg = (a + b + c) / 3;

            Console.WriteLine("Average = " + avg);
        }

        static void Main()
        {
            AverageThree();
        }
    }
}

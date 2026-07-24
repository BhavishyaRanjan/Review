using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Power_Calculation
    {
        static void PowerValue()
        {
            Console.Write("Enter Base: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Exponent: ");
            double exp = Convert.ToDouble(Console.ReadLine());

            double ans = Math.Pow(num, exp);

            Console.WriteLine("Answer = " + ans);
        }

        static void Main()
        {
            PowerValue();
        }
    }
}

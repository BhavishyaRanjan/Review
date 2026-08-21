using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Calculate_Simple_Interest
    {
        static void SimpleInterest()
        {
            Console.Write("Enter Principal: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            double t = Convert.ToDouble(Console.ReadLine());

            double si = (p * r * t) / 100;

            Console.WriteLine("Simple Interest = " + si);
        }

        public static void Main(string[] args)
        {
            SimpleInterest();
        }
    }
}

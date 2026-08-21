using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem5_DoubleOperations
    {
        public static void Run()
        {
            Console.WriteLine("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double r1 = a + b * c;
            double r2 = a * b + c;
            double r3 = c + a / b;
            double r4 = a % b + c;

            Console.WriteLine($"The results of Double Operations are {r1}, {r2}, {r3}, and {r4}");
        }
    }
}

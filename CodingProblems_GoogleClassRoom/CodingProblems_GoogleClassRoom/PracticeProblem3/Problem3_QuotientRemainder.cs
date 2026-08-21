using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem3_QuotientRemainder
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int q = n1 / n2;
            int r = n1 % n2;

            Console.WriteLine($"The Quotient is {q} and Remainder is {r} of two numbers {n1} and {n2}");
        }
    }
}

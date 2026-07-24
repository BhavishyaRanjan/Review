using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem9_SwapNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine($"The swapped numbers are {n1} and {n2}");
        }
    }
}

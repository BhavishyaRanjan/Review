using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem4_IntOperations
    {
        public static void Run()
        {
            Console.WriteLine("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c:");
            int c = Convert.ToInt32(Console.ReadLine());

            int r1 = a + b * c;
            int r2 = a * b + c;
            int r3 = c + a / b;
            int r4 = a % b + c;

            Console.WriteLine($"The results of Int Operations are {r1}, {r2}, {r3}, and {r4}");
        }
    }
}

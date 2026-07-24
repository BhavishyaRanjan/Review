using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem12_ChocolateDivision
    {
        public static void Run()
        {
            Console.WriteLine("Enter number of chocolates:");
            int chocolates = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of children:");
            int children = Convert.ToInt32(Console.ReadLine());

            int each = chocolates / children;
            int left = chocolates % children;

            Console.WriteLine($"The number of chocolates each child gets is {each} and the number of remaining chocolates is {left}");
        }
    }
}

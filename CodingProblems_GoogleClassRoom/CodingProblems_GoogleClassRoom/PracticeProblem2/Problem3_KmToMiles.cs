using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem3_KmToMiles
    {
        public static void Run()
        {
            double km = 10.8;
            double miles = km * 1.6;

            Console.WriteLine($"3) The distance {km} km in miles is {miles:F2}");
        }
    }
}

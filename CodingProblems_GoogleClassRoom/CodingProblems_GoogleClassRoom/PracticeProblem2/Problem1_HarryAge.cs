using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem1_HarryAge
    {
        public static void Run()
        {
            int birthYear = 2000;
            int currentYear = 2024;
            int age = currentYear - birthYear;

            Console.WriteLine($"1) Harry's age in {currentYear} is {age}");
        }
    }
}

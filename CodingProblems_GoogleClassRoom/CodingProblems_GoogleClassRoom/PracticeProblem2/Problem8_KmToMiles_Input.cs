using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem8_KmToMiles_Input
    {
        public static void Run()
        {
            Console.WriteLine("\n8) Enter distance in kilometers to convert to miles:");

            if (double.TryParse(Console.ReadLine(), out double km))
            {
                double miles = km * 1.6;
                Console.WriteLine($"   The total miles is {miles:F4} mile for the given {km} km");
            }
            else
            {
                Console.WriteLine("   Invalid input for kilometers.");
            }
        }
    }
}

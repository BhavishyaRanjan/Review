using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem14_FeetToYardsMiles
    {
        public static void Run()
        {
            Console.WriteLine("\n14) Enter distance in feet:");

            if (double.TryParse(Console.ReadLine(), out double feet))
            {
                double yards = feet / 3.0;
                double miles = feet / 5280.0;

                Console.WriteLine($"   The distance {feet} feet is {yards:F2} yards and {miles:F6} miles");
            }
            else
            {
                Console.WriteLine("   Invalid input for feet.");
            }
        }
    }
}

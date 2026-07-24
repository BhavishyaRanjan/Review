using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem10_HeightCmToFeetInches
    {
        public static void Run()
        {
            Console.WriteLine("\n10) Enter your height in centimeters:");

            if (double.TryParse(Console.ReadLine(), out double cm))
            {
                double totalInches = cm / 2.54;
                int feet = (int)(totalInches / 12);
                double inches = totalInches - feet * 12;

                Console.WriteLine($"   Your Height in cm is {cm} while in feet is {feet} and inches is {inches:F2}");
            }
            else
            {
                Console.WriteLine("   Invalid input for height.");
            }
        }
    }
}

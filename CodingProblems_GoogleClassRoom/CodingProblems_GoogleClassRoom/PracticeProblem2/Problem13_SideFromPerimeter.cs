using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem13_SideFromPerimeter
    {
        public static void Run()
        {
            Console.WriteLine("\n13) Enter perimeter of square:");

            if (double.TryParse(Console.ReadLine(), out double perimeter))
            {
                double side = perimeter / 4.0;
                Console.WriteLine($"   The length of the side is {side} whose perimeter is {perimeter}");
            }
            else
            {
                Console.WriteLine("   Invalid input for perimeter.");
            }
        }
    }
}

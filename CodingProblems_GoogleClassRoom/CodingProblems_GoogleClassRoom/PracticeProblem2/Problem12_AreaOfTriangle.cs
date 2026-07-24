using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem12_AreaOfTriangle
    {
        public static void Run()
        {
            Console.WriteLine("\n12) Enter base (inches):");

            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("   Bad input");
                return;
            }

            Console.WriteLine("    Enter height (inches):");

            if (!double.TryParse(Console.ReadLine(), out double h))
            {
                Console.WriteLine("   Bad input");
                return;
            }

            double areaInSqInches = 0.5 * b * h;
            double areaInSqCm = areaInSqInches * 6.4516;

            Console.WriteLine("   Area: " + areaInSqInches.ToString("F2") + " sq in, " + areaInSqCm.ToString("F2") + " sq cm");
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom._01_C_Methods
{
    public class SquareRootProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            double number = ReadDouble();

            double result = SquareRoot(number);
            Console.WriteLine($"Square root: {result:F2}");
        }

        private static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        private static double ReadDouble()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (double.TryParse(input, out double value) && value >= 0)
                {
                    return value;
                }

                Console.Write("Enter a valid non-negative number: ");
            }
        }
    }
}

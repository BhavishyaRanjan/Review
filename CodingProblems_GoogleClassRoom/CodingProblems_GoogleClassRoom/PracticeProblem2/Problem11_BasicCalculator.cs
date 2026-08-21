using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem11_BasicCalculator
    {
        public static void Run()
        {
            Console.WriteLine("\n11) Basic Calculator - enter first number:");
            string aStr = Console.ReadLine();

            Console.WriteLine("    Enter second number:");
            string bStr = Console.ReadLine();

            if (double.TryParse(aStr, out double a) && double.TryParse(bStr, out double b))
            {
                double sum = a + b;
                double diff = a - b;
                double prod = a * b;
                string div = b != 0
                    ? (a / b).ToString("F4")
                    : "Infinity (division by zero)";

                Console.WriteLine($"   The addition, subtraction, multiplication and division value of 2 numbers {a} and {b} is {sum}, {diff}, {prod}, and {div}");
            }
            else
            {
                Console.WriteLine("   Invalid inputs for calculator.");
            }
        }
    }
}

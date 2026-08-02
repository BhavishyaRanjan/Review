using System;

namespace CodingProblems_GoogleClassRoom._01_C_Methods
{
    public class FactorialProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = ReadPositiveInteger();

            int result = Factorial(number);
            Console.WriteLine($"Factorial: {result}");
        }

        private static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        private static int ReadPositiveInteger()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int value) && value >= 0)
                {
                    return value;
                }

                Console.Write("Enter a valid non-negative number: ");
            }
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom._01_C_Methods
{
    public class SumOfDigitsProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = ReadPositiveInteger();

            int[] digits = GetDigits(number);
            int sum = SumArray(digits);

            Console.WriteLine($"Sum of digits: {sum}");
        }

        private static int[] GetDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];

            for (int index = count - 1; index >= 0; index--)
            {
                digits[index] = number % 10;
                number /= 10;
            }

            return digits;
        }

        private static int CountDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        private static int SumArray(int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
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

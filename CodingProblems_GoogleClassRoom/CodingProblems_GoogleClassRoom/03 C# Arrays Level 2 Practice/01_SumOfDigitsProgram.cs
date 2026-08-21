using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class SumOfDigitsProgram
    {
        public static void Run()
        {
            // Take input from the user
            Console.Write("Enter a number: ");
            string input = Console.ReadLine() ?? string.Empty;

            // Validate the input
            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine("Invalid number. Please enter a non-negative integer.");
                return;
            }

            // Find the count of digits
            int digitCount = input.Length;

            // Store each digit in an array
            int[] digits = new int[digitCount];
            int workingNumber = number;

            for (int index = 0; index < digitCount; index++)
            {
                digits[index] = workingNumber % 10;
                workingNumber /= 10;
            }

            // Find the sum of the digits
            int sum = 0;
            for (int index = 0; index < digits.Length; index++)
            {
                sum += digits[index];
            }

            // Display the result
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}

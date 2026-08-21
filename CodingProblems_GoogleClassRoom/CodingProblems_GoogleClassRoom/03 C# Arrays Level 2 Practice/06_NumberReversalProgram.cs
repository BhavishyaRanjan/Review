using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class NumberReversalProgram
    {
        public static void Run()
        {
            // Take input for a number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine() ?? string.Empty;

            // Validate the input
            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine("Invalid number. Please enter a non-negative integer.");
                return;
            }

            // Store digits and reverse them
            int digitCount = input.Length;
            int[] digits = new int[digitCount];
            int[] reversedDigits = new int[digitCount];
            int workingNumber = number;

            for (int index = 0; index < digitCount; index++)
            {
                digits[index] = workingNumber % 10;
                workingNumber /= 10;
            }

            for (int index = 0; index < digitCount; index++)
            {
                reversedDigits[index] = digits[digitCount - 1 - index];
            }

            // Display the reversed digits
            Console.WriteLine("Original digits:");
            for (int index = 0; index < digits.Length; index++)
            {
                Console.Write(digits[index] + " ");
            }

            Console.WriteLine("\nReversed digits:");
            for (int index = 0; index < reversedDigits.Length; index++)
            {
                Console.Write(reversedDigits[index] + " ");
            }
        }
    }
}

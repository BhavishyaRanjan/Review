using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class DigitFrequencyProgram
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

            // Store digits in an array
            int digitCount = input.Length;
            int[] digits = new int[digitCount];
            int workingNumber = number;

            for (int index = 0; index < digitCount; index++)
            {
                digits[index] = workingNumber % 10;
                workingNumber /= 10;
            }

            // Count frequency of each digit
            int[] frequency = new int[10];
            for (int index = 0; index < digits.Length; index++)
            {
                frequency[digits[index]]++;
            }

            // Display the frequency of each digit
            Console.WriteLine("Digit frequencies:");
            for (int digit = 0; digit < frequency.Length; digit++)
            {
                if (frequency[digit] > 0)
                {
                    Console.WriteLine($"Digit {digit}: {frequency[digit]}");
                }
            }
        }
    }
}

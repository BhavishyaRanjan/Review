using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class LargestAndSecondLargestDigitProgram
    {
        public static void Run()
        {
            // Take input for the number
            Console.Write("Enter a number: ");
            string input = Console.ReadLine() ?? string.Empty;

            // Validate the input
            if (!int.TryParse(input, out int number) || number < 0)
            {
                Console.WriteLine("Invalid number. Please enter a non-negative integer.");
                return;
            }

            // Store digits in an array and grow the array if needed
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int digitIndex = 0;
            int workingNumber = number;

            while (workingNumber != 0)
            {
                if (digitIndex == maxDigit)
                {
                    int[] tempArray = new int[maxDigit + 10];
                    Array.Copy(digits, tempArray, digits.Length);
                    digits = tempArray;
                    maxDigit += 10;
                }

                digits[digitIndex] = workingNumber % 10;
                workingNumber /= 10;
                digitIndex++;
            }

            // Find the largest and second largest digits
            int largestDigit = 0;
            int secondLargestDigit = 0;

            for (int index = 0; index < digitIndex; index++)
            {
                int currentDigit = digits[index];

                if (currentDigit > largestDigit)
                {
                    secondLargestDigit = largestDigit;
                    largestDigit = currentDigit;
                }
                else if (currentDigit > secondLargestDigit && currentDigit != largestDigit)
                {
                    secondLargestDigit = currentDigit;
                }
            }

            // Display the result
            Console.WriteLine($"Largest digit: {largestDigit}");
            Console.WriteLine($"Second largest digit: {secondLargestDigit}");
        }
    }
}

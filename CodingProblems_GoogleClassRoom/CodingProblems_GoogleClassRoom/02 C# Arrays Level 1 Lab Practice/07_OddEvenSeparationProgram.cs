using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class OddEvenSeparationProgram
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = ReadPositiveInteger();

            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];
            int oddIndex = 0;
            int evenIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
        }

        private static int ReadPositiveInteger()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int value) && value > 0)
                {
                    return value;
                }

                Console.Error.WriteLine("Invalid number. Enter a natural number.");
            }
        }
    }
}

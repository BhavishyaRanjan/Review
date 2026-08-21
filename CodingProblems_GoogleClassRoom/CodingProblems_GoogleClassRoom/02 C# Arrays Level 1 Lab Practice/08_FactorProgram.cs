using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class FactorProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = ReadPositiveInteger();

            int[] factors = new int[10];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index >= factors.Length)
                    {
                        Array.Resize(ref factors, factors.Length * 2);
                    }

                    factors[index] = i;
                    index++;
                }
            }

            Console.WriteLine("Factors:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(factors[i]);
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

                Console.Error.WriteLine("Invalid number. Enter a positive integer.");
            }
        }
    }
}

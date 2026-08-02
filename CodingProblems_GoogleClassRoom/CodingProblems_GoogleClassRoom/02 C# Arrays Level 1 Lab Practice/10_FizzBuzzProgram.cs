using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class FizzBuzzProgram
    {
        public static void Run()
        {
            Console.Write("Enter a positive integer: ");
            int number = ReadPositiveInteger();

            string[] results = new string[number + 1];

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                else
                {
                    results[i] = i.ToString();
                }
            }

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Position {i} = {results[i]}");
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

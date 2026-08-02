using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class NumberTypeProgram
    {
        public static void Run()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = ReadInteger();
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine($"{numbers[i]} is positive and even.");
                    }
                    else
                    {
                        Console.WriteLine($"{numbers[i]} is positive and odd.");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine($"{numbers[i]} is negative.");
                }
                else
                {
                    Console.WriteLine("0 is zero.");
                }
            }

            if (numbers[0] == numbers[^1])
            {
                Console.WriteLine("First and last elements are equal.");
            }
            else if (numbers[0] > numbers[^1])
            {
                Console.WriteLine("First element is greater than the last element.");
            }
            else
            {
                Console.WriteLine("First element is less than the last element.");
            }
        }

        private static int ReadInteger()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.Error.WriteLine("Invalid number.");
            }
        }
    }
}

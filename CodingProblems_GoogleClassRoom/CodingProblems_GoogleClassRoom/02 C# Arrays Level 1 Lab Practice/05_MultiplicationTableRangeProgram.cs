using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class MultiplicationTableRangeProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number from 6 to 9: ");
            int number = ReadInteger(6, 9);

            int[] multiplicationResult = new int[10];

            for (int i = 0; i < multiplicationResult.Length; i++)
            {
                multiplicationResult[i] = number * (i + 1);
                Console.WriteLine($"{number} * {i + 1} = {multiplicationResult[i]}");
            }
        }

        private static int ReadInteger(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int value) && value >= min && value <= max)
                {
                    return value;
                }

                Console.Error.WriteLine($"Invalid number. Enter a value between {min} and {max}.");
            }
        }
    }
}

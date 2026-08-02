using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class MultiplicationTableProgram
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = ReadInteger();

            int[] multiplicationTable = new int[10];

            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                multiplicationTable[i] = number * (i + 1);
                Console.WriteLine($"{number} * {i + 1} = {multiplicationTable[i]}");
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

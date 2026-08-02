using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class MatrixToOneDimensionalArrayProgram
    {
        public static void Run()
        {
            Console.Write("Enter number of rows: ");
            int rows = ReadPositiveInteger();

            Console.Write("Enter number of columns: ");
            int columns = ReadPositiveInteger();

            int[,] matrix = new int[rows, columns];
            int[] oneDimensionalArray = new int[rows * columns];
            int index = 0;

            Console.WriteLine("Enter the matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"matrix[{i},{j}]: ");
                    matrix[i, j] = ReadInteger();
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    oneDimensionalArray[index] = matrix[i, j];
                    index++;
                }
            }

            Console.WriteLine("Copied array:");
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                Console.WriteLine(oneDimensionalArray[i]);
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

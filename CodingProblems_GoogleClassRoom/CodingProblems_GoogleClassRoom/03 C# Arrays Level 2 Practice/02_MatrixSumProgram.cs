using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class MatrixSumProgram
    {
        public static void Run()
        {
            // Take input for rows and columns
            int rows = ReadPositiveInteger("Enter number of rows: ");
            int columns = ReadPositiveInteger("Enter number of columns: ");

            // Create a 2D array
            int[,] matrix = new int[rows, columns];

            // Fill the matrix with user values
            Console.WriteLine("Enter matrix values:");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = ReadInteger($"Value [{row}, {column}]: ");
                }
            }

            // Display matrix and calculate total sum
            int sum = 0;
            Console.WriteLine("\nMatrix values:");
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                    sum += matrix[row, column];
                }
                Console.WriteLine();
            }

            // Display the final sum
            Console.WriteLine($"\nSum of all elements: {sum}");
        }

        private static int ReadPositiveInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(input, out int value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

        private static int ReadInteger(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(input, out int value))
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}

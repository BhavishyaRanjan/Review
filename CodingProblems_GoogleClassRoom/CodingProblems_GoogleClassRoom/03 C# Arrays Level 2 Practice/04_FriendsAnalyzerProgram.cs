using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class FriendsAnalyzerProgram
    {
        public static void Run()
        {
            // Store friend names in an array
            string[] friendNames = { "Amar", "Akbar", "Anthony" };

            // Create arrays for age and height
            int[] ages = new int[friendNames.Length];
            double[] heights = new double[friendNames.Length];

            // Take input for each friend
            for (int index = 0; index < friendNames.Length; index++)
            {
                ages[index] = ReadPositiveInteger($"Age of {friendNames[index]}: ");
                heights[index] = ReadPositiveDouble($"Height of {friendNames[index]} in meters: ");
            }

            // Find the youngest and tallest friend
            int youngestIndex = 0;
            int tallestIndex = 0;

            for (int index = 1; index < friendNames.Length; index++)
            {
                if (ages[index] < ages[youngestIndex])
                {
                    youngestIndex = index;
                }

                if (heights[index] > heights[tallestIndex])
                {
                    tallestIndex = index;
                }
            }

            // Display the result
            Console.WriteLine($"\nYoungest friend: {friendNames[youngestIndex]} ({ages[youngestIndex]} years)");
            Console.WriteLine($"Tallest friend: {friendNames[tallestIndex]} ({heights[tallestIndex]} m)");
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

        private static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(input, out double value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class FootballTeamHeightProgram
    {
        public static void Run()
        {
            double[] heights = new double[11];
            double totalHeight = 0.0;

            Console.WriteLine("Enter the heights of 11 players:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write($"Player {i + 1} height: ");
                heights[i] = ReadDouble();
                totalHeight += heights[i];
            }

            double meanHeight = totalHeight / heights.Length;
            Console.WriteLine($"Mean height of the football team: {meanHeight:F2}");
        }

        private static double ReadDouble()
        {
            while (true)
            {
                string input = Console.ReadLine() ?? string.Empty;
                if (double.TryParse(input, out double value))
                {
                    return value;
                }

                Console.Error.WriteLine("Invalid height.");
            }
        }
    }
}

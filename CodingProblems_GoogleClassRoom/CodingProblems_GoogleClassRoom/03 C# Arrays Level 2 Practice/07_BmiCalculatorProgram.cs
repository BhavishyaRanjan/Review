using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class BmiCalculatorProgram
    {
        public static void Run()
        {
            // Take input for the number of people
            int personCount = ReadPositiveInteger("Enter number of persons: ");

            // Create arrays to store data
            double[] weights = new double[personCount];
            double[] heights = new double[personCount];
            double[] bmis = new double[personCount];
            string[] statuses = new string[personCount];

            // Take input for each person's weight and height
            for (int index = 0; index < personCount; index++)
            {
                weights[index] = ReadPositiveDouble($"Weight for person {index + 1} in kg: ");
                heights[index] = ReadPositiveDouble($"Height for person {index + 1} in meters: ");
            }

            // Calculate BMI and status for each person
            for (int index = 0; index < personCount; index++)
            {
                bmis[index] = weights[index] / (heights[index] * heights[index]);

                if (bmis[index] < 18.5)
                {
                    statuses[index] = "Underweight";
                }
                else if (bmis[index] < 25)
                {
                    statuses[index] = "Normal";
                }
                else if (bmis[index] < 30)
                {
                    statuses[index] = "Overweight";
                }
                else
                {
                    statuses[index] = "Obese";
                }
            }

            // Display the result for each person
            Console.WriteLine("\nBMI Report");
            for (int index = 0; index < personCount; index++)
            {
                Console.WriteLine($"Person {index + 1}: Weight = {weights[index]} kg, Height = {heights[index]} m, BMI = {bmis[index]:F2}, Status = {statuses[index]}");
            }
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

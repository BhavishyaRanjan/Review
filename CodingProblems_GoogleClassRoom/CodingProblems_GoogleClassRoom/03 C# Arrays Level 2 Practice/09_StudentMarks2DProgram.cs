using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class StudentMarks2DProgram
    {
        public static void Run()
        {
            // Take input for the number of students
            int studentCount = ReadPositiveInteger("Enter number of students: ");

            // Create a 2D array for marks
            double[,] marks = new double[studentCount, 3];
            double[] percentages = new double[studentCount];
            string[] grades = new string[studentCount];

            // Take input for marks in three subjects
            string[] subjects = { "Physics", "Chemistry", "Maths" };
            for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
            {
                for (int subjectIndex = 0; subjectIndex < subjects.Length; subjectIndex++)
                {
                    marks[studentIndex, subjectIndex] = ReadNonNegativeDouble($"{subjects[subjectIndex]} marks for student {studentIndex + 1}: ");
                }
            }

            // Calculate percentage and grade
            for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
            {
                double totalMarks = marks[studentIndex, 0] + marks[studentIndex, 1] + marks[studentIndex, 2];
                percentages[studentIndex] = totalMarks / 3;

                if (percentages[studentIndex] >= 90)
                {
                    grades[studentIndex] = "A";
                }
                else if (percentages[studentIndex] >= 80)
                {
                    grades[studentIndex] = "B";
                }
                else if (percentages[studentIndex] >= 70)
                {
                    grades[studentIndex] = "C";
                }
                else if (percentages[studentIndex] >= 60)
                {
                    grades[studentIndex] = "D";
                }
                else
                {
                    grades[studentIndex] = "F";
                }
            }

            // Display the report
            Console.WriteLine("\nStudent Report (2D Array)");
            for (int studentIndex = 0; studentIndex < studentCount; studentIndex++)
            {
                Console.WriteLine($"Student {studentIndex + 1}: Physics = {marks[studentIndex, 0]}, Chemistry = {marks[studentIndex, 1]}, Maths = {marks[studentIndex, 2]}, Percentage = {percentages[studentIndex]:F2}%, Grade = {grades[studentIndex]}");
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

        private static double ReadNonNegativeDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(input, out double value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a non-negative number.");
            }
        }
    }
}

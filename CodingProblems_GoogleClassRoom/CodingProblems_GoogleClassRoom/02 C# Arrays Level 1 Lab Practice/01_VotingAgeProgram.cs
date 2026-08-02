using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class VotingAgeProgram
    {
        public static void Run()
        {
            int[] ages = new int[10];

            Console.WriteLine("Enter the age of 10 students:");
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Student {i + 1} age: ");
                ages[i] = ReadInteger();
            }

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine($"Student {i + 1}: Invalid age.");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine($"Student {i + 1}: The student with age {ages[i]} can vote.");
                }
                else
                {
                    Console.WriteLine($"Student {i + 1}: The student with age {ages[i]} cannot vote.");
                }
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

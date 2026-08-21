using System;

namespace CodingProblems_GoogleClassRoom._02_C_Arrays_Level_1_Lab_Practice
{
    public class StoreNumbersProgram
    {
        public static void Run()
        {
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;

            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double value = ReadDouble();

                if (value <= 0)
                {
                    break;
                }

                if (index >= numbers.Length)
                {
                    Console.WriteLine("Maximum of 10 values reached.");
                    break;
                }

                numbers[index] = value;
                index++;
            }

            for (int i = 0; i < index; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine("Numbers entered:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine($"Total: {total}");
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

                Console.Error.WriteLine("Invalid number.");
            }
        }
    }
}

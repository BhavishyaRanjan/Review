using System;

namespace CodingProblems_GoogleClassRoom._01_C_Methods
{
    public class KmToMilesProgram
    {
        public static void Run()
        {
            Console.Write("Enter distance in km: ");
            double km = ReadDouble();

            double miles = ConvertKmToMiles(km);
            Console.WriteLine($"Miles: {miles:F2}");
        }

        private static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
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

                Console.Write("Enter a valid number: ");
            }
        }
    }
}

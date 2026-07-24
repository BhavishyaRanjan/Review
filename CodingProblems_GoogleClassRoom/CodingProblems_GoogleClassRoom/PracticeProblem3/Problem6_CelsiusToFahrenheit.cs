using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem6_CelsiusToFahrenheit
    {
        public static void Run()
        {
            Console.WriteLine("Enter temperature in Celsius:");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = c * 9 / 5 + 32;

            Console.WriteLine($"The {c} Celsius is {f} Fahrenheit");
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem7_FahrenheitToCelsius
    {
        public static void Run()
        {
            Console.WriteLine("Enter temperature in Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;

            Console.WriteLine($"The {f} Fahrenheit is {c} Celsius");
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom;

public class WindChillCalculator
{
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    public void Run()
    {
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        Console.WriteLine($"Wind chill temperature: {windChill:F2}");
    }
}

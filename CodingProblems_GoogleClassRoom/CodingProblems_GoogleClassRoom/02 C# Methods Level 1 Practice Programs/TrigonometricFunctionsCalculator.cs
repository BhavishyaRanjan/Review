using System;

namespace CodingProblems_GoogleClassRoom;

public class TrigonometricFunctionsCalculator
{
    public double[] CalculateTrigonometricFunctions(double angleInDegrees)
    {
        double angleInRadians = angleInDegrees * Math.PI / 180;
        return new[]
        {
            Math.Sin(angleInRadians),
            Math.Cos(angleInRadians),
            Math.Tan(angleInRadians)
        };
    }

    public void Run()
    {
        Console.Write("Enter angle in degrees: ");
        double angleInDegrees = Convert.ToDouble(Console.ReadLine());

        double[] results = CalculateTrigonometricFunctions(angleInDegrees);
        Console.WriteLine($"Sine: {results[0]:F4}");
        Console.WriteLine($"Cosine: {results[1]:F4}");
        Console.WriteLine($"Tangent: {results[2]:F4}");
    }
}

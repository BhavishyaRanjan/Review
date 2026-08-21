using System;

namespace CodingProblems_GoogleClassRoom;

public class QuadraticEquationSolver
{
    public double[] FindRoots(double coefficientA, double coefficientB, double coefficientC)
    {
        double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;

        if (discriminant > 0)
        {
            double root1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
            double root2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            return new[] { root1, root2 };
        }

        if (discriminant == 0)
        {
            double root = -coefficientB / (2 * coefficientA);
            return new[] { root };
        }

        return Array.Empty<double>();
    }

    public void Run()
    {
        Console.Write("Enter coefficient a: ");
        double coefficientA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double coefficientB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double coefficientC = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(coefficientA, coefficientB, coefficientC);

        if (roots.Length == 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"Single root: {roots[0]:F2}");
        }
        else
        {
            Console.WriteLine($"Root 1: {roots[0]:F2}");
            Console.WriteLine($"Root 2: {roots[1]:F2}");
        }
    }
}

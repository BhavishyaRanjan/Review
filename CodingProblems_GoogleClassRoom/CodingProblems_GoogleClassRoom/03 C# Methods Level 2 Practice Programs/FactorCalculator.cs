using System;

namespace CodingProblems_GoogleClassRoom;

public class FactorCalculator
{
    public int[] FindFactors(int number)
    {
        int count = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index++] = i;
            }
        }

        return factors;
    }

    public int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }

        return sum;
    }

    public int FindProductOfFactors(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }

        return product;
    }

    public double FindSumOfSquaresOfFactors(int[] factors)
    {
        double sum = 0;
        foreach (int factor in factors)
        {
            sum += Math.Pow(factor, 2);
        }

        return sum;
    }

    public void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine($"Sum of factors: {FindSumOfFactors(factors)}");
        Console.WriteLine($"Product of factors: {FindProductOfFactors(factors)}");
        Console.WriteLine($"Sum of squares of factors: {FindSumOfSquaresOfFactors(factors):F2}");
    }
}

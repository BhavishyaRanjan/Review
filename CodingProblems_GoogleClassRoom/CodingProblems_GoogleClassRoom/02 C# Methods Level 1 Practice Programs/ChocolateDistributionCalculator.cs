using System;

namespace CodingProblems_GoogleClassRoom;

public class ChocolateDistributionCalculator
{
    public int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        int chocolatesEach = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        return new[] { chocolatesEach, remainingChocolates };
    }

    public void Run()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
        Console.WriteLine($"Each child gets: {result[0]}, Remaining chocolates: {result[1]}");
    }
}

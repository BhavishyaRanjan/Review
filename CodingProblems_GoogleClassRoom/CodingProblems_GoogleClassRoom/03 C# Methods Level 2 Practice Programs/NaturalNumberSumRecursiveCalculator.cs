using System;

namespace CodingProblems_GoogleClassRoom;

public class NaturalNumberSumRecursiveCalculator
{
    public int FindSumUsingRecursion(int number)
    {
        if (number <= 0)
        {
            return 0;
        }

        return number + FindSumUsingRecursion(number - 1);
    }

    public int FindSumUsingFormula(int number)
    {
        return number * (number + 1) / 2;
    }

    public bool IsNaturalNumber(int number)
    {
        return number > 0;
    }

    public void Run()
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (!IsNaturalNumber(number))
        {
            Console.WriteLine("Input is not a natural number.");
            return;
        }

        int recursiveSum = FindSumUsingRecursion(number);
        int formulaSum = FindSumUsingFormula(number);

        Console.WriteLine($"Recursive sum: {recursiveSum}");
        Console.WriteLine($"Formula sum: {formulaSum}");
        Console.WriteLine($"Results are equal: {recursiveSum == formulaSum}");
    }
}

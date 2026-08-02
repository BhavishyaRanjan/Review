using System;

namespace CodingProblems_GoogleClassRoom;

public class NaturalNumberSumCalculator
{
    public int FindSumOfNaturalNumbers(int number)
    {
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        return sum;
    }

    public void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = FindSumOfNaturalNumbers(number);
        Console.WriteLine($"Sum of first {number} natural numbers: {sum}");
    }
}

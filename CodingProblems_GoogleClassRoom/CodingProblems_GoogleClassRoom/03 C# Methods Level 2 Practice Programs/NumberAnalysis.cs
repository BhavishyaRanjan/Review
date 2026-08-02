using System;

namespace CodingProblems_GoogleClassRoom;

public class NumberAnalysis
{
    public string CheckSign(int number)
    {
        if (number > 0)
        {
            return "Positive";
        }

        if (number < 0)
        {
            return "Negative";
        }

        return "Zero";
    }

    public string CheckEvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    public int CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return 1;
        }

        if (firstNumber < secondNumber)
        {
            return -1;
        }

        return 0;
    }

    public void Run()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            string sign = CheckSign(number);
            Console.WriteLine($"{number} is {sign}");

            if (sign == "Positive")
            {
                Console.WriteLine($"{number} is {CheckEvenOrOdd(number)}");
            }
        }

        int comparisonResult = CompareNumbers(numbers[0], numbers[numbers.Length - 1]);
        if (comparisonResult == 1)
        {
            Console.WriteLine("First element is greater than last element");
        }
        else if (comparisonResult == -1)
        {
            Console.WriteLine("First element is less than last element");
        }
        else
        {
            Console.WriteLine("First element is equal to last element");
        }
    }
}

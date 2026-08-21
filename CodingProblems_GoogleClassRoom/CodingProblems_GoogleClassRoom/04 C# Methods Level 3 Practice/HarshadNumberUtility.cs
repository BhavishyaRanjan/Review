using System;

namespace CodingProblems_GoogleClassRoom;

public class HarshadNumberUtility
{
    public static int CountDigits(int number)
    {
        return NumberCheckerUtility.CountDigits(number);
    }

    public static int[] StoreDigits(int number)
    {
        return NumberCheckerUtility.StoreDigits(number);
    }

    public static int FindSumOfDigits(int[] digits)
    {
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += digit;
        }

        return sum;
    }

    public static int FindSumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += digit * digit;
        }

        return sum;
    }

    public static bool IsHarshadNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = FindSumOfDigits(digits);
        return sum != 0 && number % sum == 0;
    }

    public static int[,] FindDigitFrequency(int number)
    {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}

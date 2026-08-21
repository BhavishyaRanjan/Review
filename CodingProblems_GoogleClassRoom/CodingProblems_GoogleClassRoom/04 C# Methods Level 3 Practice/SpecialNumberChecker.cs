using System;

namespace CodingProblems_GoogleClassRoom;

public class SpecialNumberChecker
{
    public static bool IsPrimeNumber(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sum = 0;

        while (square > 0)
        {
            sum += square % 10;
            square /= 10;
        }

        return sum == number;
    }

    public static bool IsSpyNumber(int number)
    {
        int[] digits = NumberCheckerUtility.StoreDigits(number);
        int sum = 0;
        int product = 1;

        foreach (int digit in digits)
        {
            sum += digit;
            product *= digit;
        }

        return sum == product;
    }

    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        string squareText = square.ToString();
        string numberText = number.ToString();
        return squareText.EndsWith(numberText);
    }

    public static bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
}

using System;

namespace CodingProblems_GoogleClassRoom;

public class PalindromeUtility
{
    public static int[] ReverseDigits(int[] digits)
    {
        int[] reversed = new int[digits.Length];

        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }

        return reversed;
    }

    public static bool AreArraysEqual(int[] first, int[] second)
    {
        if (first.Length != second.Length)
        {
            return false;
        }

        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsPalindromeNumber(int number)
    {
        int[] digits = NumberCheckerUtility.StoreDigits(number);
        int[] reversed = ReverseDigits(digits);
        return AreArraysEqual(digits, reversed);
    }

    public static bool IsDuckNumber(int number)
    {
        return NumberCheckerUtility.IsDuckNumber(number);
    }
}

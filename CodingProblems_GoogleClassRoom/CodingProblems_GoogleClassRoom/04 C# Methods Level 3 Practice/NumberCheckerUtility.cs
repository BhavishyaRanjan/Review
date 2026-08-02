using System;

namespace CodingProblems_GoogleClassRoom;

public class NumberCheckerUtility
{
    public static int CountDigits(int number)
    {
        int count = 0;
        int temp = Math.Abs(number);

        do
        {
            count++;
            temp /= 10;
        } while (temp > 0);

        return count;
    }

    public static int[] StoreDigits(int number)
    {
        int temp = Math.Abs(number);
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        return digits;
    }

    public static bool IsDuckNumber(int number)
    {
        int[] digits = StoreDigits(number);

        foreach (int digit in digits)
        {
            if (digit != 0)
            {
                return true;
            }
        }

        return false;
    }

    public static bool IsArmstrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int count = digits.Length;
        double sum = 0;

        foreach (int digit in digits)
        {
            sum += Math.Pow(digit, count);
        }

        return Math.Abs(sum - number) < 1e-9;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }

        return new[] { largest, secondLargest };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest)
            {
                secondSmallest = digit;
            }
        }

        return new[] { smallest, secondSmallest };
    }
}

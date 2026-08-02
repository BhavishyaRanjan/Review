using System;

namespace CodingProblems_GoogleClassRoom;

public class Level3PracticeProgram
{
    public static void Main()
    {
        Console.WriteLine("=== Football Team Statistics ===");
        new FootballTeamStatistics().DisplayResults();

        Console.WriteLine();
        Console.WriteLine("=== Number Checker Utility ===");
        int number = 153;
        int[] digits = NumberCheckerUtility.StoreDigits(number);
        Console.WriteLine($"Digits of {number}: {string.Join(", ", digits)}");
        Console.WriteLine($"Digit count: {NumberCheckerUtility.CountDigits(number)}");
        Console.WriteLine($"Duck number: {NumberCheckerUtility.IsDuckNumber(number)}");
        Console.WriteLine($"Armstrong number: {NumberCheckerUtility.IsArmstrongNumber(number)}");
        Console.WriteLine($"Largest and second largest: {string.Join(", ", NumberCheckerUtility.FindLargestAndSecondLargest(digits))}");
        Console.WriteLine($"Smallest and second smallest: {string.Join(", ", NumberCheckerUtility.FindSmallestAndSecondSmallest(digits))}");

        Console.WriteLine();
        Console.WriteLine("=== Harshad Number Utility ===");
        int harshadNumber = 21;
        int[] harshadDigits = HarshadNumberUtility.StoreDigits(harshadNumber);
        Console.WriteLine($"Digits of {harshadNumber}: {string.Join(", ", harshadDigits)}");
        Console.WriteLine($"Sum of digits: {HarshadNumberUtility.FindSumOfDigits(harshadDigits)}");
        Console.WriteLine($"Sum of squares: {HarshadNumberUtility.FindSumOfSquaresOfDigits(harshadDigits)}");
        Console.WriteLine($"Harshad number: {HarshadNumberUtility.IsHarshadNumber(harshadNumber)}");

        Console.WriteLine();
        Console.WriteLine("=== Palindrome Utility ===");
        int palindromeNumber = 121;
        Console.WriteLine($"Palindrome number: {PalindromeUtility.IsPalindromeNumber(palindromeNumber)}");
        Console.WriteLine($"Duck number: {PalindromeUtility.IsDuckNumber(palindromeNumber)}");

        Console.WriteLine();
        Console.WriteLine("=== Special Number Checker ===");
        int specialNumber = 7;
        Console.WriteLine($"Prime: {SpecialNumberChecker.IsPrimeNumber(specialNumber)}");
        Console.WriteLine($"Neon: {SpecialNumberChecker.IsNeonNumber(specialNumber)}");
        Console.WriteLine($"Spy: {SpecialNumberChecker.IsSpyNumber(specialNumber)}");
        Console.WriteLine($"Automorphic: {SpecialNumberChecker.IsAutomorphicNumber(specialNumber)}");
        Console.WriteLine($"Buzz: {SpecialNumberChecker.IsBuzzNumber(specialNumber)}");
    }
}

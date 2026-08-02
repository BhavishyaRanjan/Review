using System;

namespace CodingProblems_GoogleClassRoom;

public class LeapYearChecker
{
    public bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            return false;
        }

        if (year % 400 == 0)
        {
            return true;
        }

        if (year % 100 == 0)
        {
            return false;
        }

        return year % 4 == 0;
    }

    public void Run()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsLeapYear(year) ? "The year is a Leap Year" : "The year is not a Leap Year");
    }
}

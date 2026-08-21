using System;

namespace CodingProblems_GoogleClassRoom;

public class SpringSeasonChecker
{
    public bool IsSpringSeason(int month, int day)
    {
        if (month == 3)
        {
            return day >= 20;
        }

        if (month > 3 && month < 6)
        {
            return true;
        }

        if (month == 6)
        {
            return day <= 20;
        }

        return false;
    }

    public void Run()
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpringSeason = IsSpringSeason(month, day);
        Console.WriteLine(isSpringSeason ? "Its a Spring Season" : "Not a Spring Season");
    }
}

using System;

namespace CodingProblems_GoogleClassRoom;

public class NumberSignChecker
{
    public int CheckSign(int number)
    {
        if (number > 0)
        {
            return 1;
        }
        else if (number < 0)
        {
            return -1;
        }

        return 0;
    }

    public void Run()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckSign(number);
        Console.WriteLine($"Result: {result}");
    }
}

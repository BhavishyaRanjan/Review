using System;

namespace CodingProblems_GoogleClassRoom;

public class SimpleInterestCalculator
{
    public double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    public void Run()
    {
        Console.Write("Enter principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}

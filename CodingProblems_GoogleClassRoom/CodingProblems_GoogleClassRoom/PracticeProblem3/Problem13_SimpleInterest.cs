using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem13_SimpleInterest
    {
        public static void Run()
        {
            Console.WriteLine("Enter principal:");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate:");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter time:");
            double time = Convert.ToDouble(Console.ReadLine());

            double interest = principal * rate * time / 100;

            Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}

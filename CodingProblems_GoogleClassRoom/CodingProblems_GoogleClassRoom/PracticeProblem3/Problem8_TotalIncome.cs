using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem8_TotalIncome
    {
        public static void Run()
        {
            Console.WriteLine("Enter salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter bonus:");
            double bonus = Convert.ToDouble(Console.ReadLine());

            double income = salary + bonus;

            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}");
        }
    }
}

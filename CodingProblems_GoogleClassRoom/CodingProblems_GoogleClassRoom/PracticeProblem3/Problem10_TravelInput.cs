using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem10_TravelInput
    {
        public static void Run()
        {
            Console.WriteLine("Enter traveller name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter starting city:");
            string from = Console.ReadLine();

            Console.WriteLine("Enter via city:");
            string via = Console.ReadLine();

            Console.WriteLine("Enter final city:");
            string to = Console.ReadLine();

            Console.WriteLine("Enter first distance in miles:");
            double d1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second distance in miles:");
            double d2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter first travel time in minutes:");
            int t1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second travel time in minutes:");
            int t2 = Convert.ToInt32(Console.ReadLine());

            double totalD = d1 + d2;
            int totalT = t1 + t2;

            Console.WriteLine($"The results of the trip are: {name}, {totalD} miles, and {totalT} minutes from {from} to {to} via {via}");
        }
    }
}

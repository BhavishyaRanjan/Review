using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem11_TriangleRounds
    {
        public static void Run()
        {
            Console.WriteLine("Enter first side in meters:");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side in meters:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side in meters:");
            double s3 = Convert.ToDouble(Console.ReadLine());

            double peri = s1 + s2 + s3;
            double dist = 5 * 1000;
            double rounds = dist / peri;

            Console.WriteLine($"The total number of rounds the athlete will run is {rounds} to complete 5 km");
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem1_DisplayResult
    {
        public static void Run()
        {
            string name = "Sam";
            int roll = 1;
            double marks = 99.99;
            char result = 'P';

            Console.WriteLine($"Displaying Result:\n{name} with Roll Number {roll} has Scored {marks}% Marks and Result is {result}");
        }
    }
}

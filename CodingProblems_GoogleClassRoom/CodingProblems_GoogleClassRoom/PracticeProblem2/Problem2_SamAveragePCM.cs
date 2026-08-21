using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem2_SamAveragePCM
    {
        public static void Run()
        {
            int maths = 94;
            int physics = 95;
            int chemistry = 96;

            double average = (maths + physics + chemistry) / 3.0;

            Console.WriteLine($"2) Sam's average mark in PCM is {average:F2}");
        }
    }
}

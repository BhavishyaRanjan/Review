using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem5_PensDivision
    {
        public static void Run()
        {
            int totalPens = 14;
            int students = 3;
            int pensPerStudent = totalPens / students;
            int remaining = totalPens % students;

            Console.WriteLine($"5) The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remaining}");
        }
    }
}

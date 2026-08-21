using System;

namespace CodingProblems_GoogleClassRoom;

public class StudentVoteChecker
{
    public bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }

        return age >= 18;
    }

    public void Run()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: {(CanStudentVote(ages[i]) ? "Can vote" : "Cannot vote")}");
        }
    }
}

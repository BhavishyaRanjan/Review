using System;

namespace CodingProblems_GoogleClassRoom;

public class FriendComparison
{
    public int FindYoungest(int[] ages)
    {
        int youngestIndex = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }
        }

        return youngestIndex;
    }

    public int FindTallest(int[] heights)
    {
        int tallestIndex = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        return tallestIndex;
    }

    public void Run()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Enter age for {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height for {names[i]}: ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }

        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        Console.WriteLine($"Youngest friend: {names[youngestIndex]} ({ages[youngestIndex]})");
        Console.WriteLine($"Tallest friend: {names[tallestIndex]} ({heights[tallestIndex]})");
    }
}

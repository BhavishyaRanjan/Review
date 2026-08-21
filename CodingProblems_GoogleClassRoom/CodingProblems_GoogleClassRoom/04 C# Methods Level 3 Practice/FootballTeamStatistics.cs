using System;

namespace CodingProblems_GoogleClassRoom;

public class FootballTeamStatistics
{
    private readonly Random _random = new();

    public int[] GenerateHeights()
    {
        int[] heights = new int[11];

        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = _random.Next(150, 251);
        }

        return heights;
    }

    public int FindSum(int[] heights)
    {
        int sum = 0;

        foreach (int height in heights)
        {
            sum += height;
        }

        return sum;
    }

    public double FindMean(int[] heights)
    {
        return (double)FindSum(heights) / heights.Length;
    }

    public int FindShortest(int[] heights)
    {
        int shortest = heights[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < shortest)
            {
                shortest = heights[i];
            }
        }

        return shortest;
    }

    public int FindTallest(int[] heights)
    {
        int tallest = heights[0];

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
            }
        }

        return tallest;
    }

    public void DisplayResults()
    {
        int[] heights = GenerateHeights();

        Console.WriteLine("Football team heights in cm:");
        foreach (int height in heights)
        {
            Console.Write(height + " ");
        }

        Console.WriteLine();
        Console.WriteLine($"Sum of heights: {FindSum(heights)}");
        Console.WriteLine($"Mean height: {FindMean(heights):F2}");
        Console.WriteLine($"Shortest height: {FindShortest(heights)}");
        Console.WriteLine($"Tallest height: {FindTallest(heights)}");
    }
}

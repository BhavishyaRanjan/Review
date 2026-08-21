using System;

namespace CodingProblems_GoogleClassRoom;

public class RandomNumberStatistics
{
    public int[] Generate4DigitRandomArray(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }

        return numbers;
    }

    public double[] FindAverageMinMax(int[] numbers)
    {
        double average = numbers.Average();
        int minimum = numbers.Min();
        int maximum = numbers.Max();

        return new[] { average, minimum, maximum };
    }

    public void Run()
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);
        Console.WriteLine("Random numbers: " + string.Join(", ", randomNumbers));

        double[] result = FindAverageMinMax(randomNumbers);
        Console.WriteLine($"Average: {result[0]:F2}");
        Console.WriteLine($"Minimum: {result[1]}");
        Console.WriteLine($"Maximum: {result[2]}");
    }
}

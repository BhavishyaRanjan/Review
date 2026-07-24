using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem14_PoundsToKilograms
    {
        public static void Run()
        {
            Console.WriteLine("Enter weight in pounds:");
            double pounds = Convert.ToDouble(Console.ReadLine());
            double kgPerPound = 2.2;
            double kg = pounds / kgPerPound;

            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kg}");
        }
    }
}

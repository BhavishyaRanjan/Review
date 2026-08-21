using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem16_MaxHandshakes
    {
        public static void Run()
        {
            Console.WriteLine("\n16) Enter number of students:");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                long handshakes = (long)n * (n - 1) / 2;

                Console.WriteLine($"   The maximum number of handshakes among {n} students is {handshakes}");
            }
            else
            {
                Console.WriteLine("   Invalid input for number of students.");
            }
        }
    }
}

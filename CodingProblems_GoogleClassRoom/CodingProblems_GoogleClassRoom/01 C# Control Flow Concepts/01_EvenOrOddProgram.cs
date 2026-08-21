using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class EvenOrOddProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is the number even? " + (number % 2 == 0));
            Console.WriteLine("Is the number positive? " + (number > 0));
            Console.WriteLine("Is the number zero? " + (number == 0));
        }
    }
}

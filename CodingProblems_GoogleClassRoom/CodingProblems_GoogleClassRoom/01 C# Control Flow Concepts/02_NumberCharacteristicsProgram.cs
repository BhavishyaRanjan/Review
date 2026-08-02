using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class NumberCharacteristicsProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is number even and greater than or equal to 10? " + ((number % 2 == 0) && (number >= 10)));
            Console.WriteLine("Is the number divisible by 3 or 4? " + ((number % 3 == 0) || (number % 4 == 0)));
            Console.WriteLine("Is the number not zero and divisible by 3? " + ((number != 0) && (number % 3 == 0)));
        }
    }
}

using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class SumOfDigitsProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number:");
            int originalNumber = Convert.ToInt32(Console.ReadLine());

            int number = originalNumber;
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }

            Console.WriteLine($"The sum of digits of {originalNumber} is {sum}");
        }
    }
}

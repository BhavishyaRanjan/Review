using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class PassOrFailProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter grade:");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade.");
            }
            else if (grade >= 50)
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You passed the examination.");
            }
            else
            {
                Console.WriteLine("Sorry.");
                Console.WriteLine("You failed the examination.");
            }
        }
    }
}

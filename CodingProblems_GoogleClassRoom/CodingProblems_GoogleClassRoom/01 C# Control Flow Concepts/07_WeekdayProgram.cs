using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class WeekdayProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number between 1 and 7:");
            int weekDayNumber = Convert.ToInt32(Console.ReadLine());

            switch (weekDayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}

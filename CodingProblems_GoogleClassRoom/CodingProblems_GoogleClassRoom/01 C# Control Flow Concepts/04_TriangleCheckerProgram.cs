using System;

namespace CodingProblems_GoogleClassRoom._01_C_Control_Flow_Concepts
{
    public class TriangleCheckerProgram
    {
        public static void Run()
        {
            Console.WriteLine("Enter three angles of a triangle:");
            int angle1 = Convert.ToInt32(Console.ReadLine());
            int angle2 = Convert.ToInt32(Console.ReadLine());
            int angle3 = Convert.ToInt32(Console.ReadLine());

            int sumOfAngles = angle1 + angle2 + angle3;

            Console.WriteLine($"The given angles {angle1}, {angle2}, {angle3} add to {sumOfAngles}");

            if (sumOfAngles == 180)
            {
                Console.WriteLine("The given angles are internal angles of a triangle.");
            }
            else
            {
                Console.WriteLine("The given angles are not internal angles of a triangle.");
            }
        }
    }
}

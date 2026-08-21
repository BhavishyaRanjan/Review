using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Area_of_a_circle
    {
        public void Area_of_circle(double radius)
        {
            double pie = 3.14;
            double area = pie * Math.Pow(radius, 2);
            Console.WriteLine($"Area of the circle: {area}");
        }

        public static void Main(string[] args)
        {
            Area_of_a_circle area_of_a_Circle = new Area_of_a_circle();
            area_of_a_Circle.Area_of_circle(10);
        }
    }
}

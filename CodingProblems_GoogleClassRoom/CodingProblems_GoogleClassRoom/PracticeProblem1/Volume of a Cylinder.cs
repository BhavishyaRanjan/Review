using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Volume_of_a_Cylinder
    {
        public void Volume_of_Cylinder(double radius, double height)
        {
            double pie = 3.14;
            double Volume = pie * Math.Pow(radius, 2) * height;
            Console.WriteLine("Volume of Cylinder is: " + Volume);
        }

        public static void main(string[] args)
        {
            Volume_of_a_Cylinder volume_of_a_Cylinder = new Volume_of_a_Cylinder();
            volume_of_a_Cylinder.Volume_of_Cylinder(10, 20);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Perimeter_of_a_Rectangle
    {
        static void RectanglePerimeter()
        {
            Console.Write("Enter Length: ");
            double len = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width: ");
            double wid = Convert.ToDouble(Console.ReadLine());

            double per = 2 * (len + wid);

            Console.WriteLine("Perimeter = " + per);
        }

        static void Main()
        {
            RectanglePerimeter();
        }
    }
}

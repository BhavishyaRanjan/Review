using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Convert_Kilometers_to_Miles
    {
        static void KmToMiles()
        {
            Console.Write("Enter Kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double mile = km * 0.621371;

            Console.WriteLine("Miles = " + mile);
        }

        static void Main()
        {
            KmToMiles();
        }
    }
}

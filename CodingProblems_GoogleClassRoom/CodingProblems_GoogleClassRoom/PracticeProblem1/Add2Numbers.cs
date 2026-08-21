using System;
using System.Collections.Generic;
using System.Text;

namespace CodingProblems_GoogleClassRoom.PracticeProblem1
{
    internal class Add2Numbers
    {
        public void addition(int number1,int number2)
        {
            Console.WriteLine(number1 + number2);
        }
        public static void main(string[] args)
        {
            Add2Numbers add2Numbers = new Add2Numbers();
            add2Numbers.addition(10, 20);   
        }

    }
}

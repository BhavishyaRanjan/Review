using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem3
{
    public static class Problem2_EricTravels
    {
        public static void Run()
        {
            string name = "Eric";
            string from = "Chennai";
            string via = "Vellore";
            string to = "Bangalore";
            double d1 = 156.6;
            double d2 = 211.8;
            int t1 = 4 * 60 + 4;
            int t2 = 4 * 60 + 25;
            double totalD = d1 + d2;
            int totalT = t1 + t2;

            Console.WriteLine($"The Total Distance travelled by {name} from {from} to {to} via {via} is {totalD} km and the Total Time taken is {totalT} minutes");
        }
    }
}

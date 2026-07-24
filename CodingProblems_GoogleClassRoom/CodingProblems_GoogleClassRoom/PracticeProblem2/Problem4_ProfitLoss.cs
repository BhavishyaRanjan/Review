using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem4_ProfitLoss
    {
        public static void Run()
        {
            double costPrice = 129.0;
            double sellingPrice = 191.0;
            double profit = sellingPrice - costPrice;
            double profitPercent = profit / costPrice * 100.0;

            Console.WriteLine($"4) The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}");
            Console.WriteLine($"   The Profit is INR {profit} and the Profit Percentage is {profitPercent:F2}%");
        }
    }
}

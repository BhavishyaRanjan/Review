using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem15_TotalPurchasePrice
    {
        public static void Run()
        {
            Console.WriteLine("\n15) Enter unit price (INR):");
            string priceStr = Console.ReadLine();

            Console.WriteLine("    Enter quantity:");
            string qtyStr = Console.ReadLine();

            if (double.TryParse(priceStr, out double unitPrice) &&
                int.TryParse(qtyStr, out int quantity))
            {
                double total = unitPrice * quantity;

                Console.WriteLine($"   The total purchase price is INR {total} if the quantity {quantity} and unit price is INR {unitPrice}");
            }
            else
            {
                Console.WriteLine("   Invalid input for unit price or quantity.");
            }
        }
    }
}

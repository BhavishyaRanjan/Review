using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem9_DiscountWithInput
    {
        public static void Run()
        {
            Console.WriteLine("\n9) Enter fee (INR):");
            string feeInput = Console.ReadLine();

            Console.WriteLine("   Enter discount percent (e.g., 10 for 10%):");
            string discInput = Console.ReadLine();

            if (double.TryParse(feeInput, out double fee) &&
                double.TryParse(discInput, out double discountPercent))
            {
                double discount = fee * discountPercent / 100.0;
                double finalFee = fee - discount;

                Console.WriteLine($"   The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
            }
            else
            {
                Console.WriteLine("   Invalid input for fee or discount percent.");
            }
        }
    }
}

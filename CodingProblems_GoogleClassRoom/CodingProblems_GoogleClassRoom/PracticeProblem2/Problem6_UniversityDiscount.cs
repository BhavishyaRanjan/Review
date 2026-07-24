using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem6_UniversityDiscount
    {
        public static void Run()
        {
            double fee = 125000.0;
            double discountPercent = 10.0;
            double discount = fee * discountPercent / 100.0;
            double finalFee = fee - discount;

            Console.WriteLine($"6) The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
        }
    }
}

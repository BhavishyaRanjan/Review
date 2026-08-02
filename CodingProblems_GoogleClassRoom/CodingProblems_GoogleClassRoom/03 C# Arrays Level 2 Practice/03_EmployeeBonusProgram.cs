using System;

namespace CodingProblems_GoogleClassRoom._03_C_Arrays_Level_2_Lab_Practice
{
    public class EmployeeBonusProgram
    {
        public static void Run()
        {
            // Define the number of employees
            const int employeeCount = 10;

            // Create arrays to store employee data
            double[] salaries = new double[employeeCount];
            double[] yearsOfService = new double[employeeCount];
            double[] bonuses = new double[employeeCount];
            double[] newSalaries = new double[employeeCount];

            // Take input for each employee
            int employeeIndex = 0;
            while (employeeIndex < employeeCount)
            {
                salaries[employeeIndex] = ReadPositiveDouble($"Salary for employee {employeeIndex + 1}: ");
                yearsOfService[employeeIndex] = ReadNonNegativeDouble($"Years of service for employee {employeeIndex + 1}: ");

                employeeIndex++;
            }

            // Calculate bonus and new salary for each employee
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for (int index = 0; index < salaries.Length; index++)
            {
                double bonusRate = yearsOfService[index] > 5 ? 0.05 : 0.02;
                bonuses[index] = salaries[index] * bonusRate;
                newSalaries[index] = salaries[index] + bonuses[index];

                totalBonus += bonuses[index];
                totalOldSalary += salaries[index];
                totalNewSalary += newSalaries[index];
            }

            // Display the summary
            Console.WriteLine("\nBonus Summary");
            Console.WriteLine($"Total bonus payout: {totalBonus:C}");
            Console.WriteLine($"Total old salary: {totalOldSalary:C}");
            Console.WriteLine($"Total new salary: {totalNewSalary:C}");
        }

        private static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(input, out double value) && value > 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        private static double ReadNonNegativeDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(input, out double value) && value >= 0)
                {
                    return value;
                }

                Console.WriteLine("Invalid input. Please enter a non-negative number.");
            }
        }
    }
}

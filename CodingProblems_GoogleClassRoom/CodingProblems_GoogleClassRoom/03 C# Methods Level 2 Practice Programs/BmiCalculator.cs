using System;

namespace CodingProblems_GoogleClassRoom;

public class BmiCalculator
{
    public double[,] CalculateBmi(double[,] peopleData)
    {
        for (int i = 0; i < peopleData.GetLength(0); i++)
        {
            double weightInKg = peopleData[i, 0];
            double heightInCm = peopleData[i, 1];
            double heightInMeters = heightInCm / 100;
            double bmi = weightInKg / (heightInMeters * heightInMeters);
            peopleData[i, 2] = bmi;
        }

        return peopleData;
    }

    public string[] DetermineBmiStatus(double[,] peopleData)
    {
        string[] status = new string[peopleData.GetLength(0)];

        for (int i = 0; i < peopleData.GetLength(0); i++)
        {
            double bmi = peopleData[i, 2];

            if (bmi < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi < 25)
            {
                status[i] = "Normal";
            }
            else if (bmi < 30)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obese";
            }
        }

        return status;
    }

    public void Run()
    {
        double[,] peopleData = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter weight for person {i + 1} (kg): ");
            peopleData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter height for person {i + 1} (cm): ");
            peopleData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        double[,] bmiData = CalculateBmi(peopleData);
        string[] status = DetermineBmiStatus(bmiData);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}: Weight={bmiData[i, 0]}, Height={bmiData[i, 1]} cm, BMI={bmiData[i, 2]:F2}, Status={status[i]}");
        }
    }
}

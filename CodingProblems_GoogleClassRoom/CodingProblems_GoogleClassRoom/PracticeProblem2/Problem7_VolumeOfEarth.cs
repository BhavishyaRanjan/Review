using System;

namespace CodingProblems_GoogleClassRoom.PracticeProblem2
{
    public static class Problem7_VolumeOfEarth
    {
        public static void Run()
        {
            double radiusKm = 6378.0;
            double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
            double kmToMiles = 0.621371;
            double volumeMiles3 = volumeKm3 * Math.Pow(kmToMiles, 3);

            Console.WriteLine($"7) The volume of earth in cubic kilometers is {volumeKm3:E3} and cubic miles is {volumeMiles3:E3}");
        }
    }
}

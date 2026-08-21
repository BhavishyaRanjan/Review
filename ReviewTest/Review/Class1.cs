using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReviewTest{
    public interface ILocation{
        double Lat { get; }
        double Lon { get; }
    }
    public class Driver : ILocation{
        public string Id { get; }
        public double Lat { get; }
        public double Lon { get; }
        public double Rating { get; }
        public bool Available { get; }

        public Driver(string id, double lat, double lon, double rating, bool available){
            Id = id;
            Lat = lat;
            Lon = lon;
            Rating = rating;
            Available = available;
        }
    }

    public class SpatialIndex<T> where T:ILocation{
        public List<T> List { get; } = new List<T>();
        public void Add(T obj) => List.Add(obj);
    }

    public class RideHailingService{
        public const string RequestPattern =
            @"REQ(?<id>\d+)\|PICKUP:(?<lat>-?\d+(\.\d+)?),(?<lon>-?\d+(\.\d+)?)\|" +
            @"DEST:(?<dlat>-?\d+(\.\d+)?),(?<dlon>-?\d+(\.\d+)?)\|" +
            @"TIME:(?<time>[^|]+)\|RIDER:(?<tier>\w+)";

        public static double Distance(double lat1, double lon1, double lat2, double lon2){
            double a = lat1 - lat2;
            double b = lon1 - lon2;
            return Math.Sqrt(a * a + b * b);
        }
        public static Driver FindBestDriver(IEnumerable<Driver> drivers, double lat, double lon, double radius){
            Driver best = null;
            double bestScore = double.MinValue;
            foreach (var d in drivers.Where(d => d.Available)){
                double distance = Distance(lat, lon, d.Lat, d.Lon);
                if (distance <= radius){
                    double score = (d.Rating * 0.3) - (distance * 0.7);
                    if (score > bestScore){
                        bestScore = score;
                        best = d;
                    }
                }
            }

            return best;
        }
        public static double CalculateSurge(int demand, int supply){
            double ratio = supply == 0 ? 999 : (double)demand / supply;
            if (ratio < 1) return 1.0;
            if (ratio < 2) return 1.2;
            if (ratio < 3) return 1.5;
            return 2.0;
        }
    }

    class Program{
        static void Main(){
            string input = "REQ7781|PICKUP:12.34,77.56|DEST:12.40,77.60|TIME:2026-08-18T14:30:00|RIDER:premium";
            Match m = Regex.Match(input, RideHailingService.RequestPattern);
            if (!m.Success){
                Console.WriteLine("Invalid request");
                return;
            }

            string id = m.Groups["id"].Value;
            double lat = double.Parse(m.Groups["lat"].Value, CultureInfo.InvariantCulture);
            double lon = double.Parse(m.Groups["lon"].Value, CultureInfo.InvariantCulture);

            Console.WriteLine($"Request: {id}");
            Console.WriteLine($"Pickup: {lat},{lon}");

            var drivers = new SpatialIndex<Driver>();
            drivers.Add(new Driver("D1", 12.35, 77.57, 4.5, true));
            drivers.Add(new Driver("D2", 12.50, 77.70, 4.9, true));
            drivers.Add(new Driver("D3", 12.36, 77.58, 4.2, true));

            Driver best = RideHailingService.FindBestDriver(drivers.List, lat, lon, radius: 1.0);
            Console.WriteLine(best != null ? $"Best Driver: {best.Id}" : "No driver found");

            int supply = drivers.List.Count(d => d.Available);
            double surge = RideHailingService.CalculateSurge(demand: 3, supply);
            Console.WriteLine($"Surge: {surge}x");
        }
    }
}
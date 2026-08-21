using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace ReviewTest{
    [TestFixture]
    public class RideHailingTests{
        private string _requestPattern;
        private List<Driver> _testDrivers;

        [SetUp]
        public void Setup(){
            _requestPattern =
                @"REQ(?<id>\d+)\|PICKUP:(?<lat>-?\d+(\.\d+)?),(?<lon>-?\d+(\.\d+)?)\|" +
                @"DEST:(?<dlat>-?\d+(\.\d+)?),(?<dlon>-?\d+(\.\d+)?)\|" +
                @"TIME:(?<time>[^|]+)\|RIDER:(?<tier>\w+)";

            _testDrivers = new List<Driver>
            {
                new Driver("D1", 12.35, 77.57, 4.5, true),
                new Driver("D2", 12.50, 77.70, 4.9, true),
                new Driver("D3", 12.36, 77.58, 4.2, true),
                new Driver("D4", 12.34, 77.56, 5.0, false)
            };
        }
        [TestCase("REQ7781|PICKUP:12.34,77.56|DEST:12.40,77.60|TIME:2026-08-18T14:30:00|RIDER:premium", true, "7781", 12.34, 77.56)]
        [TestCase("REQ01|PICKUP:-33.86,151.20|DEST:-33.88,151.21|TIME:2026-01-01T00:00:00|RIDER:standard", true, "01", -33.86, 151.20)]
        [TestCase("INVALID_FORMAT_STRING", false, null, 0, 0)]
        [TestCase("REQABC|PICKUP:12.34,77.56|DEST:12.40,77.60|TIME:2026-08-18T14:30:00|RIDER:premium", false, null, 0, 0)]
        public void ParseRequest_ValidatesAndExtractsData(string input, bool expectedSuccess, string expectedId, double expectedLat, double expectedLon)
        {
            Match match = Regex.Match(input, _requestPattern);

            Assert.That(match.Success, Is.EqualTo(expectedSuccess));

            if (expectedSuccess){
                Assert.That(match.Groups["id"].Value, Is.EqualTo(expectedId));
                double parsedLat = double.Parse(match.Groups["lat"].Value, CultureInfo.InvariantCulture);
                double parsedLon = double.Parse(match.Groups["lon"].Value, CultureInfo.InvariantCulture);
                Assert.That(parsedLat, Is.EqualTo(expectedLat).Within(0.0001));
                Assert.That(parsedLon, Is.EqualTo(expectedLon).Within(0.0001));
            }
        }
        private static double Distance(double lat1, double lon1, double lat2, double lon2){
            double a=lat1-lat2;
            double b=lon1-lon2;
            return Math.Sqrt(a*a+b*b);
        }
        [Test]
        public void Distance_SamePoint_ReturnsZero(){
            double dist = Distance(12.34, 77.56, 12.34, 77.56);
            Assert.That(dist, Is.EqualTo(0));
        }

        [Test]
        public void Distance_KnownCoordinates_ReturnsCorrectEuclideanDistance(){
            double dist = Distance(10.0, 10.0, 13.0, 14.0);
            Assert.That(dist, Is.EqualTo(5.0).Within(0.0001));
        }

        [Test]
        public void MatchDriver_SelectsHighestScoringAvailableDriverWithinRadius(){
            double pickupLat = 12.34, pickupLon = 77.56;
            double radius = 1.0;
            Driver best = null;
            double bestScore = -999;

            foreach(var d in _testDrivers){
                if (d.Available){
                    double distance = Distance(pickupLat, pickupLon, d.Lat, d.Lon);
                    if (distance <= radius){
                        double score = (d.Rating * 0.3) - (distance * 0.7);
                        if (score > bestScore) {
                            bestScore = score;
                            best = d;
                        }
                    }
                }
            }

            Assert.That(best, Is.Not.Null);
            Assert.That(best.Id, Is.EqualTo("D1"));
        }

    }
}
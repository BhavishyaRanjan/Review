using System;

namespace CodingProblems_GoogleClassRoom;

public class UnitConverter
{
    public static double ConvertKilometersToMiles(double kilometers)
    {
        const double kilometersToMiles = 0.621371;
        return kilometers * kilometersToMiles;
    }

    public static double ConvertMilesToKilometers(double miles)
    {
        const double milesToKilometers = 1.60934;
        return miles * milesToKilometers;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        const double metersToFeet = 3.28084;
        return meters * metersToFeet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        const double feetToMeters = 0.3048;
        return feet * feetToMeters;
    }

    public static double ConvertYardsToFeet(double yards)
    {
        const double yardsToFeet = 3;
        return yards * yardsToFeet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        const double feetToYards = 0.333333;
        return feet * feetToYards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        const double metersToInches = 39.3701;
        return meters * metersToInches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        const double inchesToMeters = 0.0254;
        return inches * inchesToMeters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        const double inchesToCentimeters = 2.54;
        return inches * inchesToCentimeters;
    }

    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        const double poundsToKilograms = 0.453592;
        return pounds * poundsToKilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        const double kilogramsToPounds = 2.20462;
        return kilograms * kilogramsToPounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        const double gallonsToLiters = 3.78541;
        return gallons * gallonsToLiters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        const double litersToGallons = 0.264172;
        return liters * litersToGallons;
    }
}

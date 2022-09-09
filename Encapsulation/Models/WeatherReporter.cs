using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private double _temperatureInFarenheit;
        private const double MINIMUM_TEMPERATURE_LIMIT = 10;
        private const double MAXIMUM_TEMPERATURE_LIMIT = 30;

        //Overloaded constructor to run from console terminal
        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        //Method to calculate temperature in Farenheit
        public double CalculateTemperatureInFarenheit()
        {
            _temperatureInFarenheit = Math.Round(((9.0 / 5.0) * _temperature + 32), 2);
            return _temperatureInFarenheit;
        }

        //Method to display the weather report
        public string DisplayWeatherReport()
        {
            string displayMessage = $"I am in {_location} and it is {FindWeatherAtLocation()}. " +
                $"{FindFeelLikeTemperature()}. The temperature in Fahrenheit is {CalculateTemperatureInFarenheit()}.";
            Console.WriteLine(displayMessage);
            return displayMessage;
        }

        //Method to find weather at different locations
        public string FindWeatherAtLocation()
        {
            return _location == "London" ? "🌦"
                : _location == "California" ? "🌅"
                : _location == "Cape Town" ? "🌤"
                : "🔆";
        }

        //Method to find the feel like temperature
        public string FindFeelLikeTemperature()
        {
            return _temperature > MAXIMUM_TEMPERATURE_LIMIT ? "It's too hot 🥵!"
                : _temperature < MINIMUM_TEMPERATURE_LIMIT ? "It's too cold 🥶!"
                : "Ahhh...it's just right 😊!";
        }

    }
}


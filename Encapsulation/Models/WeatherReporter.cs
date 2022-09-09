using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        private string _location;
        private double _temperature;
        private double _temperatureInFareheit;
        private const double MINIMUM_TEMPERATURE_LIMIT = 10;
        private const double MAXIMUM_TEMPERATURE_LIMIT = 30;

        public WeatherReporter()
        {
            
        }
        public WeatherReporter(string location, double temperature)
        {
            _location = location;
            _temperature = temperature;
        }

        public double CalculateTemperatureInFarenheit()
        {
            _temperatureInFareheit = Math.Round(((9.0 / 5.0) * _temperature + 32), 2);
            return _temperatureInFareheit;
        }
        public string DisplayWeatherReport()
        {
            string displayMessage = $"I am in {_location} and it is {FindWeatherForecast()}. " +
                $"{FindFeelLikeTemperature()}. The temperature in Fahrenheit is {CalculateTemperatureInFarenheit()}.";
            Console.WriteLine(displayMessage);
            return displayMessage;
        }

        public string FindWeatherForecast()
        {
            return _location == "London" ? "🌦"
                : _location == "California" ? "🌅"
                : _location == "Cape Town" ? "🌤"
                : "🔆";
        }

        public string FindFeelLikeTemperature()
        {
            return _temperature > MAXIMUM_TEMPERATURE_LIMIT ? "It's too hot 🥵!"
                : _temperature < MINIMUM_TEMPERATURE_LIMIT ? "It's too cold 🥶!"
                : "Ahhh...it's just right 😊!";
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Encapsulation.Models;
using System.Runtime.CompilerServices;

namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {
        private WeatherReporter _weatherReporter;

        [SetUp]
        public void Setup()
        {
            _weatherReporter = new WeatherReporter();            
        }

        [Test]
        public void CalculateTemperatureInFarenheit_Should_Return_Correct_Temperature_In_Farenheit()
        {
            _weatherReporter = new("", 25.0);
            _weatherReporter.CalculateTemperatureInFarenheit().Should().Be(77);
        }

        [Test]
        public void DisplayWeatherReport_Should_Return_Correct_Message()
        {
            _weatherReporter = new("London", 25.0);
            
            string displayMessage = $"I am in London and it is 🌦. " +
                $"Ahhh...it's just right 😊!. The temperature in Fahrenheit is 77.";
            _weatherReporter.DisplayWeatherReport().Should().Be(displayMessage);
        }
    }
}

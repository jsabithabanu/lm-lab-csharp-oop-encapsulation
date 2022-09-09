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
        {}

        [Test]
        public void CalculateTemperatureInFarenheit_Should_Return_Correct_Temperature_In_Farenheit()
        {
            _weatherReporter = new("", 25.5);
            _weatherReporter.CalculateTemperatureInFarenheit().Should().Be(77.9);
        }

        [Test]
        public void DisplayWeatherReport_Should_Return_Correct_Message()
        {
            _weatherReporter = new("London", 25.0);

            string displayMessage = $"I am in London and it is 🌦. " +
                $"Ahhh...it's just right 😊!. The temperature in Fahrenheit is 77.";

            _weatherReporter.DisplayWeatherReport().Should().Be(displayMessage);
        }

        [Test]
        public void FindFeelLikeTemperature_Should_Return_Too_Hot()
        {
            _weatherReporter = new("India", 40);
            _weatherReporter.FindFeelLikeTemperature().Should().Be("It's too hot 🥵!");
        }

        [Test]
        public void FindFeelLikeTemperature_Should_Return_Too_Cold()
        {
            _weatherReporter = new("London", 4);
            _weatherReporter.FindFeelLikeTemperature().Should().Be("It's too cold 🥶!");
        }

        [Test]
        public void FindFeelLikeTemperature_Should_Return_Just_Right()
        {
            _weatherReporter = new("London", 18);
            _weatherReporter.FindFeelLikeTemperature().Should().Be("Ahhh...it's just right 😊!");
        }

        [Test]
        public void FindWeatherAnLocation_Should_Return_Correct_Weather_At_London()
        {
            _weatherReporter = new("London", 15);
            _weatherReporter.FindWeatherAtLocation().Should().Be("🌦");
        }

        [Test]
        public void FindWeatherAtLocation_Should_Return_Correct_Weather_At_California()
        {
            _weatherReporter = new("California", 15);
            _weatherReporter.FindWeatherAtLocation().Should().Be("🌅");
        }

        [Test]
        public void FindWeatherAtLocation_Should_Return_Correct_Weather_In_Cape_Town()
        {
            _weatherReporter = new("Cape Town", 15);
            _weatherReporter.FindWeatherAtLocation().Should().Be("🌤");
        }

        [Test]
        public void FindWeatherAtLocation_Should_Return_Correct_Weather_In_India()
        {
            _weatherReporter = new("India", 35);
            _weatherReporter.FindWeatherAtLocation().Should().Be("🔆");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Encapsulation.Models;

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

    }
}

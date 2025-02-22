using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [TestInitialize]
        public void SetUp()
        {
            _converter = new TemperatureConverter();
        }

        // Test for Celsius to Fahrenheit conversion
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            // Test valid conversions
            Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0)); // 0°C to 32°F
            Assert.AreEqual(212, _converter.CelsiusToFahrenheit(100)); // 100°C to 212°F
            Assert.AreEqual(-40, _converter.CelsiusToFahrenheit(-40)); // -40°C to -40°F
        }

        // Test for Fahrenheit to Celsius conversion
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            // Test valid conversions
            Assert.AreEqual(0, _converter.FahrenheitToCelsius(32)); // 32°F to 0°C
            Assert.AreEqual(100, _converter.FahrenheitToCelsius(212)); // 212°F to 100°C
            Assert.AreEqual(-40, _converter.FahrenheitToCelsius(-40)); // -40°F to -40°C
        }

        // Test for invalid inputs (optional, but can check edge cases)
        [TestMethod]
        public void TestInvalidCelsiusToFahrenheit()
        {
            // Invalid Celsius input can be handled gracefully as this is just a calculation
            // But we could assert that if there are edge cases, they are handled in application logic elsewhere.
            double result = _converter.CelsiusToFahrenheit(double.NaN);
            Assert.AreEqual(double.NaN, result); // NaN should return NaN
        }

        [TestMethod]
        public void TestInvalidFahrenheitToCelsius()
        {
            // Similarly, testing for NaN in Fahrenheit
            double result = _converter.FahrenheitToCelsius(double.NaN);
            Assert.AreEqual(double.NaN, result); // NaN should return NaN
        
        }
    }
    using System;

public class TemperatureConverter
    {
        // Method to convert Celsius to Fahrenheit
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Method to convert Fahrenheit to Celsius
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }


}

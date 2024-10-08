using KDSB.Temperatura;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSB.Temperatura.Tests
{
    [TestClass()]
    public class ConvertidorTemperaturasTests
    {
        [TestMethod()]
        public void CelsiusAFahrenheitTest()
        {
            // Arrange
            ConvertidorTemperaturas convertidor = new ConvertidorTemperaturas();

            // Act
            double result = convertidor.CelsiusAFahrenheit(0);

            // Assert
            Assert.AreEqual(32, result, "La conversión de Celsius a Fahrenheit falló.");
        }

        [TestMethod()]
        public void FahrenheitACelsiusTest()
        {
            // Arrange
            ConvertidorTemperaturas convertidor = new ConvertidorTemperaturas();

            // Act
            double result = convertidor.FahrenheitACelsius(32);

            // Assert
            Assert.AreEqual(0, result, 0.01, "La conversión de Fahrenheit a Celsius falló.");
        }
    }
}
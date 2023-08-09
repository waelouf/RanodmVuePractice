using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherAppWebApi.Services;
using WeatherAppWebApi.Entities;

namespace WeatherAppWebApi.Tests
{
    [TestClass]
    public class WeatherServiceTests
    {
        private WeatherService _weatherService;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize WeatherService with a mock IConfigurationManager
            _weatherService = new WeatherService(new MockConfigurationManager());
        }

        [TestMethod]
        public void GetWeather_ReturnsExpectedResult()
        {
            // Arrange
            string city = "London";

            // Act
            Result<WeatherDetails> result = _weatherService.GetWeather(city);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Data);
        }

        [TestMethod]
        public void GetAlert_ReturnsExpectedResult()
        {
            // Arrange
            string state = "CA";

            // Act
            Result<WeatherAlerts> result = _weatherService.GetAlert(state);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Data);
        }
    }
}
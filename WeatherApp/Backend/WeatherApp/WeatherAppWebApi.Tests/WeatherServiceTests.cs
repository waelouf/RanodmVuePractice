using NUnit.Framework;
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
            WeatherDetails expectedDetails = new WeatherDetails(); // Add expected details here

            // Act
            Result<WeatherDetails> result = _weatherService.GetWeather(city);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(expectedDetails, result.Data); // Verify the correctness of the returned data
        }

        [TestMethod]
        public void GetAlert_ReturnsExpectedResult()
        {
            // Arrange
            string state = "CA";
            WeatherAlerts expectedAlerts = new WeatherAlerts(); // Add expected alerts here

            // Act
            Result<WeatherAlerts> result = _weatherService.GetAlert(state);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Success);
            Assert.IsNotNull(result.Data);
            Assert.AreEqual(expectedAlerts, result.Data); // Verify the correctness of the returned data
        }
    }
}
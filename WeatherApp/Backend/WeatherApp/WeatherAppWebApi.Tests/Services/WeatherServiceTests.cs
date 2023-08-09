using Xunit;
using Moq;
using WeatherAppWebApi.Services;
using WeatherAppWebApi.Abstracts;
using WeatherAppWebApi.Entities;

namespace WeatherAppWebApi.Tests.Services
{
    public class WeatherServiceTests
    {
        private readonly WeatherService _weatherService;
        private readonly Mock<IConfigurationManager> _mockConfigManager;

        public WeatherServiceTests()
        {
            _mockConfigManager = new Mock<IConfigurationManager>();
            _mockConfigManager.Setup(m => m.GetEnvironmentVariable("WeatherApi")).Returns("test_api_key");

            _weatherService = new WeatherService(_mockConfigManager.Object);
        }

        [Fact]
        public void GetWeather_ValidCity_ReturnsWeatherDetails()
        {
            // Arrange
            var city = "London";

            // Act
            var result = _weatherService.GetWeather(city);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.IsType<WeatherDetails>(result.Value);
        }
    }
}
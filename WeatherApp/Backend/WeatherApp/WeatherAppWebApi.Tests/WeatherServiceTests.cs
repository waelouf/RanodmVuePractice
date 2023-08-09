using NUnit.Framework;
using WeatherAppWebApi.Services;

namespace WeatherAppWebApi.Tests
{
    public class WeatherServiceTests
    {
        private WeatherService _weatherService;

        [SetUp]
        public void Setup()
        {
            _weatherService = new WeatherService();
        }

        [Test]
        public void GetWeather_ReturnsExpectedWeatherDetails()
        {
            var city = "London";
            var result = _weatherService.GetWeather(city);

            Assert.IsNotNull(result);
            Assert.AreEqual(city, result.Value.Location.Name);
        }

        [Test]
        public void GetAlert_ReturnsExpectedWeatherAlerts()
        {
            var state = "California";
            var result = _weatherService.GetAlert(state);

            Assert.IsNotNull(result);
            Assert.AreEqual(state, result.Value.State);
        }
    }
}
using LanguageExt.Common;
using WeatherAppWebApi.Entities;

namespace WeatherAppWebApi.Services;

public interface IWeatherService
{
    Result<WeatherAlerts> GetAlert(string state);
    Result<WeatherDetails> GetWeather(string city);
}

using LanguageExt.Common;
using Newtonsoft.Json;
using RestSharp;
using WeatherAppWebApi.Entities;

namespace WeatherAppWebApi.Services;

public class WeatherService : IWeatherService
{
    private string apiKey = "";

    public WeatherService()
    {
        var environmentVar = System.Environment.GetEnvironmentVariable("WeatherApi");
        apiKey = environmentVar.ToString();
    }

    public Result<WeatherAlerts> GetAlert(string state)
    {
        throw new NotImplementedException();
    }

    public Result<WeatherDetails> GetWeather(string city)
    {
        var options = new RestClientOptions("http://api.weatherapi.com")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest($"/v1/current.json?key={apiKey}&q={city}&aqi=no", Method.Get);
        RestResponse response = client.ExecuteAsync(request).Result;
        WeatherDetails weather = JsonConvert.DeserializeObject<WeatherDetails>(response.Content);

        return new Result<WeatherDetails>(weather);
    }
}

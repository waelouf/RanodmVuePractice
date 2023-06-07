using WeatherAppWebApi.Abstracts;
using WeatherAppWebApi.Services;

namespace WeatherAppWebApi.Endpoints;

public class WeatherEndpoint
{
    public void DefineEndpoint(WebApplication app)
    {
        app.MapGet("/", GetWeather);
        app.MapGet("/Alerts", GetAlerts);
    }

    private IResult GetAlerts(IWeatherService weatherService, string state)
    {
        return Results.Ok(weatherService.GetAlert(state));
    }

    public IResult GetWeather(IWeatherService weatherService, string city)
    {
        var weather = weatherService.GetWeather(city);

        return weather.Match<IResult>(
            s => Results.Ok(s) ,
            er => Results.BadRequest(er));
    }

    public void DefineService(IServiceCollection services)
    {
        services.AddSingleton<IConfigurationManager, Utilities.ConfigurationManager>();
        services.AddSingleton<IWeatherService, WeatherService>();
    }
}


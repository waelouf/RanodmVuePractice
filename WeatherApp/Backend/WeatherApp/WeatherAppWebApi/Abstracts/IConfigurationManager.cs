namespace WeatherAppWebApi.Abstracts
{
    public interface IConfigurationManager
    {
        string GetEnvironmentVariable(string variableName);
    }
}

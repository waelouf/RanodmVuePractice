using Microsoft.AspNetCore.DataProtection.KeyManagement;
using WeatherAppWebApi.Abstracts;

namespace WeatherAppWebApi.Utilities
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetEnvironmentVariable(string variableName)
        {
            var environmentVar = System.Environment.GetEnvironmentVariable(variableName);
            return environmentVar.ToString();
        }
    }
}

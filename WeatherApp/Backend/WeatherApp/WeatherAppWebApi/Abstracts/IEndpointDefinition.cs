namespace WeatherAppWebApi.Abstracts;

public interface IEndpointDefinition
{
    void DefineEndpoint(WebApplication app);

    void DefineService(IServiceCollection services);
}

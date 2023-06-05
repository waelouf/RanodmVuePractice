using WeatherAppWebApi.Abstracts;
using WeatherAppWebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var weatherEndpoint = new WeatherEndpoint();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
weatherEndpoint.DefineService(builder.Services);

var app = builder.Build();

weatherEndpoint.DefineEndpoint(app);
app.UseSwagger();
app.UseSwaggerUI();

app.Run();

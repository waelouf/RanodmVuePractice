using WeatherAppWebApi.Abstracts;
using WeatherAppWebApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var weatherEndpoint = new WeatherEndpoint();

builder.Services.AddCors();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
weatherEndpoint.DefineService(builder.Services);

var app = builder.Build();

app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
);

weatherEndpoint.DefineEndpoint(app);
app.UseSwagger();
app.UseSwaggerUI();

app.Run();

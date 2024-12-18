using MindWeb.Frontend.Services.WeatherService;

namespace MindWeb.Test;

public class IntegrationTests
{
    [Test]
    [Repeat(3)]
    public async Task GenerateWeatherForecast()
    {
        var weatherService = new WeatherService();

        await Assert.That(weatherService.GetWeatherForecasts().Length).IsGreaterThan(0);
    }
    
    [Test]
    [Repeat(3)]
    public async Task GenerateSingleWeatherForecastWithValidTemperatureC()
    {
        var weatherForecast = new WeatherForecast();
        await Assert.That(weatherForecast.TemperatureC).IsGreaterThanOrEqualTo(0);
    }
    
    [Test]
    [Repeat(3)]
    public async Task GenerateSingleWeatherForecastWithValidTemperatureF()
    {
        var weatherForecast = new WeatherForecast();
        await Assert.That(weatherForecast.TemperatureF).IsGreaterThanOrEqualTo(0);
    }
}
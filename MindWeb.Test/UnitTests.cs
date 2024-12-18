using MindWeb.Frontend.Services.WeatherService;

namespace MindWeb.Test;

public class UnitTests
{
    [Test]
    [Repeat(11)]
    public async Task GenerateWeatherForecastWithValidWeather()
    {
        var weatherService = new WeatherService();

        await Assert.That(weatherService.GetWeatherForecasts()[0].Summary).IsTypeOf<string>();
    }
}
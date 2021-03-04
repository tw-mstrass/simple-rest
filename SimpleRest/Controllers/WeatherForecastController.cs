using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using SimpleRest.Domain;

namespace SimpleRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecasts = Enumerable.Range(1, 5)
                .Select(WeatherForecasting.RandomForecast)
                .ToArray();

            foreach (var forecast in forecasts)
            {
                Log.Information("Created forecast for {Date}: {TempC}ºC ({Summary})",
                    forecast.Date, forecast.TemperatureC, forecast.Summary);
            }

            return forecasts;
        }
    }
}
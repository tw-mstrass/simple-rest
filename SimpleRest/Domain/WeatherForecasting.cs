using System;

namespace SimpleRest.Domain
{
    public class WeatherForecasting
    {
        private static readonly string[] Summaries =
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public static WeatherForecast RandomForecast(int dayOffset)
        {
            var rng = new Random();
            var temperatureC = rng.Next(-20, 55);
            return new WeatherForecast
            {
                Date = DateTime.Now.AddDays(dayOffset),
                TemperatureC = temperatureC,
                Summary = WeatherSummary(temperatureC: temperatureC)
            };
        }

        public static string WeatherSummary(int temperatureC)
        {
            if (temperatureC < 0)
            {
                return "Freezing";
            }

            var rng = new Random();
            return Summaries[rng.Next(Summaries.Length)];
        }
    }
}
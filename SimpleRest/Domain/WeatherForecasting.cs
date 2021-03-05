using System;
using System.Collections.Generic;

namespace SimpleRest.Domain
{
    public static class WeatherForecasting
    {
        private static readonly Dictionary<int, string> SummaryMaxValues = new()
        {
            {-1, "Freezing"},
            {5, "Bracing"},
            {10, "Chilly"},
            {15, "Cool"},
            {20, "Mild"},
            {25, "Warm"},
            {30, "Balmy"},
            {38, "Hot"},
            {45, "Sweltering"},
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
            foreach (var summaryMaxValue in SummaryMaxValues)
            {
                if (temperatureC <= summaryMaxValue.Key)
                {
                    return summaryMaxValue.Value;
                }
            }

            return "Scorching";
        }
    }
}
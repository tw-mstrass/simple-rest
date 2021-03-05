using System.Collections.Generic;
using Shouldly;
using SimpleRest.Domain;
using Xunit;

namespace SimpleRest.Tests.UnitTests
{
    public class WeatherForecastingTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void TemperatureSummaries(int temperatureC, string expectedSummary)
        {
            WeatherForecasting.WeatherSummary(temperatureC).ShouldBe(expectedSummary);
        }

        public static IEnumerable<object[]> TestData => new List<object[]>
        {
            new object[] {-20, "Freezing"},
            new object[] {-10, "Freezing"},
            new object[] {-5, "Freezing"},
            new object[] {-1, "Freezing"},
            new object[] {0, "Bracing"},
            new object[] {1, "Bracing"},
            new object[] {5, "Bracing"},
            new object[] {6, "Chilly"},
            new object[] {8, "Chilly"},
            new object[] {10, "Chilly"},
            new object[] {11, "Cool"},
            new object[] {14, "Cool"},
            new object[] {15, "Cool"},
            new object[] {16, "Mild"},
            new object[] {19, "Mild"},
            new object[] {20, "Mild"},
            new object[] {21, "Warm"},
            new object[] {25, "Warm"},
            new object[] {26, "Balmy"},
            new object[] {30, "Balmy"},
            new object[] {31, "Hot"},
            new object[] {38, "Hot"},
            new object[] {39, "Sweltering"},
            new object[] {40, "Sweltering"},
            new object[] {45, "Sweltering"},
            new object[] {46, "Scorching"},
            new object[] {55, "Scorching"},
        };
    }
}
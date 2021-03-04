using Shouldly;
using SimpleRest.Domain;
using Xunit;

namespace SimpleRest.Tests.UnitTests
{
    public class WeatherForecastControllerTest
    {
        [Theory]
        [InlineData(-20)]
        [InlineData(-10)]
        [InlineData(-5)]
        [InlineData(-1)]
        public void TemperaturesBelowZeroAreFreezing(int temperature)
        {
            WeatherForecasting.WeatherSummary(temperature).ShouldBe("Freezing");
        }
    }
}
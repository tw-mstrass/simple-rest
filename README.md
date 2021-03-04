# Simple REST

A simple REST service in C# and .NET Core for trying out building things that might be useful
in TMR projects.

Currently it is the random, nonsense weather forecast service created by `dotnet new webapi`.
It responds to `/WeatherForecast` and returns 5 days of ‘forecasts’. It also generates
OpenAPI information at `/swagger/html`.

## My additions

- `Dockerfile` that builds the app into a Docker image using Release configuration.
- Logging using [Serilog](https://serilog.net), including Development-only output to a local
  [Seq](https://datalust.co/seq) instance configured [as described
  here](https://gist.github.com/mjstrasser/78d47b99efa7fbae2dc9634012ef6c18).

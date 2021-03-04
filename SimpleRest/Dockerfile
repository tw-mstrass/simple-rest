# Build service
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /build

COPY ./*.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o bin/Release

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /webapp

COPY --from=build /build/bin/Release .

ENTRYPOINT ["dotnet", "SimpleRest.dll"]

EXPOSE 80

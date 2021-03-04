# Build service
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /webapp

COPY ./*.csproj ./
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o out

# Runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /webapp

COPY --from=build /webapp/out .

ENTRYPOINT ["dotnet", "simple-rest.dll"]

EXPOSE 80

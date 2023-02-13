FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

COPY ["src/locationapi/LocationApi.csproj", "locationapi/"]
RUN dotnet restore "locationapi/LocationApi.csproj"
COPY . .
WORKDIR "/src/locationapi"
RUN dotnet build "LocationApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LocationApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LocationApi.dll"]
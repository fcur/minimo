FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

COPY ["src/peopleapi/PeopleApi.csproj", "peopleapi/"]
RUN dotnet restore "peopleapi/PeopleApi.csproj"
COPY . .
WORKDIR "/src/peopleapi"
RUN dotnet build "PeopleApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PeopleApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PeopleApi.dll"]
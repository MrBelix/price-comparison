FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/PriceComparison.WebApi/PriceComparison.WebApi.csproj", "src/PriceComparison.WebApi/"]
RUN dotnet restore "src/PriceComparison.WebApi/PriceComparison.WebApi.csproj"
COPY . .
WORKDIR "/src/src/PriceComparison.WebApi"
RUN dotnet build "PriceComparison.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PriceComparison.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PriceComparison.WebApi.dll"]

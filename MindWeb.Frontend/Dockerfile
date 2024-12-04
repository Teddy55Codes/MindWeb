FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["MindWeb.Frontend/MindWeb.Frontend.csproj", "MindWeb.Frontend/"]
RUN dotnet restore "MindWeb.Frontend/MindWeb.Frontend.csproj"
COPY . .
WORKDIR "/src/MindWeb.Frontend"
RUN dotnet build "MindWeb.Frontend.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "MindWeb.Frontend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MindWeb.Frontend.dll"]

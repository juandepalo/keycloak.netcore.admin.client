FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Keycloak.ApiClient/Keycloak.ApiClient.csproj", "src/Keycloak.ApiClient/"]
RUN dotnet restore "src/Keycloak.ApiClient/Keycloak.ApiClient.csproj"
COPY . .
WORKDIR "/src/src/Keycloak.ApiClient"
RUN dotnet build "Keycloak.ApiClient.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Keycloak.ApiClient.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Keycloak.ApiClient.dll"]

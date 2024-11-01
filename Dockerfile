﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CloudStackCadenceIntegration/CloudStackCadenceIntegration.csproj", "CloudStackCadenceIntegration/"]
COPY ["CloudStack.Net/CloudStack.Net.csproj", "CloudStack.Net/"]
RUN dotnet restore "CloudStackCadenceIntegration/CloudStackCadenceIntegration.csproj"
COPY . .
WORKDIR "/src/CloudStackCadenceIntegration"
RUN dotnet build "CloudStackCadenceIntegration.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "CloudStackCadenceIntegration.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CloudStackCadenceIntegration.dll"]

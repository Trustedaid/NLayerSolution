﻿FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["NLayer.Web/NLayer.Web.csproj", "NLayer.Web/"]
RUN dotnet restore "NLayer.Web/NLayer.Web.csproj"
COPY . .
WORKDIR "/src/NLayer.Web"
RUN dotnet build "NLayer.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NLayer.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NLayer.Web.dll"]

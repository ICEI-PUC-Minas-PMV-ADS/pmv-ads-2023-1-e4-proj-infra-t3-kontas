#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Kontas.STS/Kontas.STS.csproj", "Kontas.STS/"]
RUN dotnet restore "Kontas.STS/Kontas.STS.csproj"
COPY . .
WORKDIR "/src/Kontas.STS"
RUN dotnet build "Kontas.STS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kontas.STS.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kontas.STS.dll"]
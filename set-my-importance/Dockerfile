#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["set-my-importance/set-my-importance.csproj", "set-my-importance/"]
RUN dotnet restore "set-my-importance/set-my-importance.csproj"
COPY . .
WORKDIR "/src/set-my-importance"
RUN dotnet build "set-my-importance.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "set-my-importance.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "set-my-importance.dll"]

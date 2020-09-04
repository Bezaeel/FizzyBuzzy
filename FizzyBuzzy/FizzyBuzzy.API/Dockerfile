FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["FizzyBuzzy/FizzyBuzzy.API/FizzyBuzzy.API.csproj", "FizzyBuzzy/FizzyBuzzy.API/"]
COPY ["FizzyBuzzy/FizzyBuzzy.Service/FizzyBuzzy.Service.csproj", "FizzyBuzzy/FizzyBuzzy.Service/"]
RUN dotnet restore "FizzyBuzzy/FizzyBuzzy.API/FizzyBuzzy.API.csproj"
COPY . .
WORKDIR "/src/FizzyBuzzy/FizzyBuzzy.API"
RUN dotnet build "FizzyBuzzy.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FizzyBuzzy.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FizzyBuzzy.API.dll"]
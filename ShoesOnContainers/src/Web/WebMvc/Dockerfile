FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src

# copy everything else and build app
COPY WebMvc.csproj WebMvc/
RUN dotnet restore WebMvc/WebMvc.csproj
WORKDIR /src/WebMvc
COPY . .
RUN dotnet build WebMvc.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WebMvc.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebMvc.dll"]
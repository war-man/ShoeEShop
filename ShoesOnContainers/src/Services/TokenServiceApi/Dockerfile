FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /src

# copy everything else and build app
COPY TokenServiceApi.csproj TokenServiceApi/
RUN dotnet restore TokenServiceApi/TokenServiceApi.csproj
WORKDIR /src/TokenServiceApi
COPY . .
RUN dotnet build TokenServiceApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish TokenServiceApi.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TokenServiceApi.dll"]
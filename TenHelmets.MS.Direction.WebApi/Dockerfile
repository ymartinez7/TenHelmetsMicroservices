FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR app
COPY . .
RUN dotnet publish -c Release -o dist TenHelmets.MS.Direction.WebApi.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
COPY --from=build app/dist dist
ENTRYPOINT ["dotnet", "dist/TenHelmets.MS.Direction.WebApi.dll"]
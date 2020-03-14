#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-nanoserver-1903 AS build
WORKDIR /src
COPY ["TenHelmets.MS.Direction.WebApi/TenHelmets.MS.Direction.WebApi.csproj", "TenHelmets.MS.Direction.WebApi/"]
RUN dotnet restore "TenHelmets.MS.Direction.WebApi/TenHelmets.MS.Direction.WebApi.csproj"
COPY . .
WORKDIR "/src/TenHelmets.MS.Direction.WebApi"
RUN dotnet build "TenHelmets.MS.Direction.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TenHelmets.MS.Direction.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TenHelmets.MS.Direction.WebApi.dll"]

#FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
#WORKDIR app
#COPY . .
#RUN dotnet publish -c Release -o dist TenHelmets.MS.Direction.WebApi.csproj
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
#COPY --from=build app/dist dist
#ENTRYPOINT ["dotnet", "dist/TenHelmets.MS.Direction.WebApi.dll"]
#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.


#https://stackoverflow.com/questions/33377022/how-to-copy-files-from-dockerfile-to-host

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/DevRel.Web.Host/DevRel.Web.Host.csproj", "src/DevRel.Web.Host/"]
COPY ["src/DevRel.Web.Core/DevRel.Web.Core.csproj", "src/DevRel.Web.Core/"]
COPY ["src/DevRel.Application/DevRel.Application.csproj", "src/DevRel.Application/"]
COPY ["src/DevRel.Core/DevRel.Core.csproj", "src/DevRel.Core/"]
COPY ["src/DevRel.EntityFrameworkCore/DevRel.EntityFrameworkCore.csproj", "src/DevRel.EntityFrameworkCore/"]
RUN dotnet restore "./src/DevRel.Web.Host/DevRel.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/DevRel.Web.Host"
RUN dotnet build "./DevRel.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DevRel.Web.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM node:latest AS buildUi
WORKDIR /src
COPY ["/src/DevRel.Web.Host/clientApp/", "clientApp/"]
WORKDIR /src/clientApp
RUN npm i --force && npm run ng build

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=buildUi /src/wwwroot/dist /app/publish/wwwroot/dist
ENTRYPOINT ["dotnet", "DevRel.Web.Host.dll"]
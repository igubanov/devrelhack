FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/DevRel.Web.Host/DevRel.Web.Host.csproj", "src/DevRel.Web.Host/"]
COPY ["src/DevRel.Web.Core/DevRel.Web.Core.csproj", "src/DevRel.Web.Core/"]
COPY ["src/DevRel.Application/DevRel.Application.csproj", "src/DevRel.Application/"]
COPY ["src/DevRel.Core/DevRel.Core.csproj", "src/DevRel.Core/"]
COPY ["src/DevRel.EntityFrameworkCore/DevRel.EntityFrameworkCore.csproj", "src/DevRel.EntityFrameworkCore/"]
WORKDIR "/src/src/DevRel.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/DevRel.Web.Host", "src/DevRel.Web.Host"]
COPY ["src/DevRel.Web.Core", "src/DevRel.Web.Core"]
COPY ["src/DevRel.Application", "src/DevRel.Application"]
COPY ["src/DevRel.Core", "src/DevRel.Core"]
COPY ["src/DevRel.EntityFrameworkCore", "src/DevRel.EntityFrameworkCore"]
WORKDIR "/src/src/DevRel.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "DevRel.Web.Host.dll"]

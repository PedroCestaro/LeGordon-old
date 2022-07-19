#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Legordon.Adm.Api/Legordon.Adm.Api.csproj", "Legordon.Adm.Api/"]
RUN dotnet restore "Legordon.Adm.Api/Legordon.Adm.Api.csproj"
COPY . .
WORKDIR "/src/Legordon.Adm.Api"
RUN dotnet build "Legordon.Adm.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Legordon.Adm.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Legordon.Adm.Api.dll"]
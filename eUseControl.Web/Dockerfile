# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiem toate folderele și soluția în container
COPY . .

# Mergem în folderul proiectului web și publicăm (build & publish)
WORKDIR /src/eUseControl.Web
RUN dotnet publish -c Release -o /app/out

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

# Copiem fișierele publicate din etapa de build
COPY --from=build /app/out ./

# Comanda de start
ENTRYPOINT ["dotnet", "eUseControl.Web.dll"]


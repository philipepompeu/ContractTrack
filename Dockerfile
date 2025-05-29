# Imagem oficial do .NET SDK para compilar o c�digo
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos do projeto e restaura as depend�ncias
COPY *.csproj ./
RUN dotnet restore

# Copia o restante dos arquivos e compila o projeto
COPY . ./
RUN dotnet publish -c Release -o out

# Imagem runtime para rodar a aplica��o
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Exponha a porta padr�o da sua aplica��o
EXPOSE 7068

# Comando para iniciar a aplica��o
ENTRYPOINT ["dotnet", "ContractTrack.dll"]

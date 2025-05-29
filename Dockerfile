# Imagem oficial do .NET SDK para compilar o código
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos do projeto e restaura as dependências
COPY *.csproj ./
RUN dotnet restore

# Copia o restante dos arquivos e compila o projeto
COPY . ./
RUN dotnet publish -c Release -o out

# Imagem runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Exponha a porta padrão da sua aplicação
EXPOSE 7068

# Comando para iniciar a aplicação
ENTRYPOINT ["dotnet", "ContractTrack.dll"]

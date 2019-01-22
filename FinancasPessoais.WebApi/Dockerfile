FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY FinancasPessoais.WebApi/FinancasPessoais.WebApi.csproj FinancasPessoais.WebApi/
RUN dotnet restore FinancasPessoais.WebApi/FinancasPessoais.WebApi.csproj
COPY . .
WORKDIR /src/FinancasPessoais.WebApi
RUN dotnet build FinancasPessoais.WebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish FinancasPessoais.WebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "FinancasPessoais.WebApi.dll"]

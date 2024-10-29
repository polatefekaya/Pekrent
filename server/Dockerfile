FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY *.sln ./
COPY src/ ./src/
RUN dotnet restore
RUN dotnet publish -c Release -o /out --no-restore --verbosity detailed

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

EXPOSE 5000
ENTRYPOINT ["dotnet", "CarRental.Api.dll"]

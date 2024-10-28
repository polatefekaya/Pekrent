FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY *.sln ./

COPY src/*/*.csproj ./src/

RUN for proj in $(find . -name "*.csproj"); do dotnet restore $proj; done

COPY . .

RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

WORKDIR /app

COPY --from=build /out .

EXPOSE 80

ENTRYPOINT ["dotnet", "CarRental.Api.dll"]  

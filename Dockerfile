# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln .
COPY thomson_project_1/*.csproj ./thomson_project_1/
RUN dotnet restore

# Copy everything else and build
COPY . .
WORKDIR /app/thomson_project_1
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image for the app runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/thomson_project_1/out ./
ENTRYPOINT ["dotnet", "thomson_project_1.dll"]

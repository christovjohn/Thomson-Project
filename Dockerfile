# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and project
COPY thomson_project_1.sln ./
COPY thomson_project_1/thomson_project_1.csproj ./thomson_project_1/
RUN dotnet restore

# Copy all files and publish
COPY . .
WORKDIR /app/thomson_project_1
RUN dotnet publish -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/thomson_project_1/out ./
ENTRYPOINT ["dotnet", "thomson_project_1.dll"]

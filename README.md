# csharp-app-build-docker

Simple C# Web API built using Docker-friendly ASP.NET Core structure.

## Run locally

```bash
dotnet build csharp-app-build-docker.slnx
dotnet run --project CsharpAppBuildDocker.Api/CsharpAppBuildDocker.Api.csproj
```

## Run tests

```bash
dotnet test csharp-app-build-docker.slnx
dotnet test csharp-app-build-docker.slnx --collect:"XPlat Code Coverage"
```

## Endpoints

1. `GET /api/health`  
   Returns application health status.
2. `GET /api/users/names`  
   Returns 10 hardcoded user names.
3. `GET /api/users/{id}/address`  
   Returns hardcoded address for a user ID.
4. `GET /api/users/{id}/associates`  
   Returns hardcoded associates for a user ID.

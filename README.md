# csharp-app-build-docker

## English

This is a test repository that uses GitHub Actions to run the CI process:

1. Build the application
2. Run unit tests
3. Generate and publish build artifacts

Docker is used to generate containerized build outputs and testing artifacts for the application.

Simple C# Web API built using a Docker-friendly ASP.NET Core structure.

### Run locally

```bash
dotnet build csharp-app-build-docker.slnx
dotnet run --project CsharpAppBuildDocker.Api/CsharpAppBuildDocker.Api.csproj
```

### Run tests

```bash
dotnet test csharp-app-build-docker.slnx
dotnet test csharp-app-build-docker.slnx --collect:"XPlat Code Coverage"
```

### Endpoints

1. GET /api/health
   Returns application health status.
2. GET /api/users/names
   Returns 10 hardcoded user names.
3. GET /api/users/{id}/address
   Returns hardcoded address for a user ID.
4. GET /api/users/{id}/associates
   Returns hardcoded associates for a user ID.

## Español

Este es un repositorio de pruebas que utiliza GitHub Actions para ejecutar el proceso de CI:

1. Compilar la aplicación
2. Ejecutar pruebas unitarias
3. Generar y publicar artefactos del build

Docker se utiliza para generar contenedores con los builds de la aplicación y los artefactos de pruebas.

API Web simple en C# construida con una estructura de ASP.NET Core amigable con Docker.

### Ejecutar localmente

```bash
dotnet build csharp-app-build-docker.slnx
dotnet run --project CsharpAppBuildDocker.Api/CsharpAppBuildDocker.Api.csproj
```

### Ejecutar pruebas

```bash
dotnet test csharp-app-build-docker.slnx
dotnet test csharp-app-build-docker.slnx --collect:"XPlat Code Coverage"
```

### Endpoints

1. GET /api/health
   Devuelve el estado de salud de la aplicación.
2. GET /api/users/names
   Devuelve 10 nombres de usuario hardcodeados.
3. GET /api/users/{id}/address
   Devuelve una dirección hardcodeada según el ID del usuario.
4. GET /api/users/{id}/associates
   Devuelve los asociados hardcodeados según el ID del usuario.

namespace CsharpAppBuildDocker.Api.Services;

public sealed class HealthService : IHealthService
{
    public string GetStatus() => "Healthy";
}

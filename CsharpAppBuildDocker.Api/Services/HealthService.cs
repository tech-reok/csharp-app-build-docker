namespace CsharpAppBuildDocker.Api.Services;

public sealed class HealthService : IHealthService
{
    public string GetStatus() => "Healthy";
    public string GetCommitHash()
    {
        var commitHash = System.IO.File.ReadAllText("appsettings.json");
        return commitHash;
    }
    public string GetVersion()
    {
        var version = System.IO.File.ReadAllText("appsettings.json");
        return version;
    }
}

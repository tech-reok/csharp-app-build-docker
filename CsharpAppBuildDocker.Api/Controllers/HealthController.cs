using CsharpAppBuildDocker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CsharpAppBuildDocker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class HealthController(IHealthService healthService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetStatus()
    {
        var version = System.IO.File.ReadAllText("appsettings.json");
        return Ok(new { status = healthService.GetStatus(), version=version, commitHash=healthService.GetCommitHash() });
    }
}

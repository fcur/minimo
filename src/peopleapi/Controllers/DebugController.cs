using Microsoft.AspNetCore.Mvc;

namespace PeopleApi.Controllers;

/// <summary>
/// For debugging purposes only1.
/// </summary>
[Route("api/debug")]
[ApiController]
public sealed class DebugController : ControllerBase
{
    /// <summary>
    /// Get metrics.
    /// </summary>
    [HttpGet("metrics")]
    public ActionResult Metrics()
    {
        return Redirect("/metrics");
    }

    /// <summary>
    /// Get health status.
    /// </summary>
    [HttpGet("health")]
    public ActionResult Health()
    {
        return Redirect("/health");
    }
}
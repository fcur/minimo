using LocationApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocationApi.Controllers;

/// <summary>
/// Location operations.
/// </summary>
[Route("api/location")]
[ApiController]
public sealed class LocationController : ControllerBase
{
    /// <summary>
    /// GET the list of locations
    /// </summary>
    [HttpGet]
    public ActionResult<Location[]> Get()
    {
        var results = new Location[] {
            new Location{ Id=Guid.NewGuid(), Name="First location"},
            new Location{ Id=Guid.NewGuid(), Name="Other location"}
        };
        
        return Ok(results);
    }

    /// <summary>
    /// GET location.
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<Location> Get(Guid id)
    {
        var result = new Location
        {
            Id = id,
            Name = "Location"
        };

        return Ok(result);
    }
}

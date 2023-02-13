using Microsoft.AspNetCore.Mvc;
using PeopleApi.Models;

namespace PeopleApi.Controllers;

/// <summary>
/// People operations.
/// </summary>
[Route("api/people")]
[ApiController]
public sealed class PeopleController : ControllerBase
{
    /// <summary>
    /// GET the list of peoples
    /// </summary>
    [HttpGet]
    public ActionResult<People[]> Get()
    {
        var results = new People[] {
            new People{ Id=Guid.NewGuid(), Firstname= "John", Lastname= "Smith" },
            new People{ Id=Guid.NewGuid(), Firstname="Eminem" }
        };

        return Ok(results);
    }

    /// <summary>
    /// GET people.
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<People> Get(Guid id)
    {
        var result = new People
        {
            Id = id,
            Firstname = "John",
            Lastname = "Smith",
        };

        return Ok(result);
    }
}

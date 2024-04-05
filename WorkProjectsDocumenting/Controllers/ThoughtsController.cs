using Microsoft.AspNetCore.Mvc;

namespace WorkProjectsDocumenting.Controllers;

[ApiController]
public class ThoughtsController : ControllerBase
{
    private readonly List<string> _thoughts = new List<string>();

    public ThoughtsController()
    {
        _thoughts.Add("Саттарова крутая");
        _thoughts.Add("Саттарова крутая?");
        _thoughts.Add("КТО ТАКАЯ САТТАРОВА?");
    }

    [HttpGet("thoughts/{index}")]
    public ActionResult<string> Index(int index)
    {
        return index < 0 || index > _thoughts.Count - 1 ? NotFound() : _thoughts[index];
    }
}
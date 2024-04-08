using Microsoft.AspNetCore.Mvc;
using SoftwareDocumentationManagementSystem.API.Contracts;
using SoftwareDocumentationManagementSystem.Core.Models;

namespace SoftwareDocumentationManagementSystem.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SoftwareController : ControllerBase
{
    public SoftwareController()
    {
        
    }

    [HttpPost]
    public async Task<ActionResult> CreateSoftware(SoftwareRequest softwareRequest)
    {
        var software = Software.Create(Guid.NewGuid(), softwareRequest.AuthorId, )
    }
}
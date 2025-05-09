using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace semantickernel_plugins;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ProtectedController : ControllerBase
{
    private readonly ILogger<ProtectedController> _logger;

    public ProtectedController(ILogger<ProtectedController> logger)
    {
        _logger = logger;
    }

    [HttpGet("data")]
    public IActionResult GetProtectedData()
    {
        var userName = User.Identity?.Name;
        _logger.LogInformation("User '{UserName}' is accessing protected data.", userName);
        return Ok(new { Message = $"Hello {userName}, this is protected!" });
    }
}

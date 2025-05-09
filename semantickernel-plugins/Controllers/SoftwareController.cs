using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace semantickernel_plugins;

[ApiController]
[Route("[controller]")]
public class SoftwareController : ControllerBase
{
    private readonly ILogger<ProtectedController> _logger;
    private readonly SoftwareOptions _softwareOptions;

    public SoftwareController(ILogger<ProtectedController> logger, 
        IOptions<SoftwareOptions> softwareOptions)
    {
        _logger = logger;
        _softwareOptions = softwareOptions.Value;
    }

    [HttpGet("version")]
    public IActionResult GetVersion()
    {
        string version = _softwareOptions.Version;
        _logger.LogInformation("Software version: {Version}", version);

        return Ok(new { Version = version });
    }
}

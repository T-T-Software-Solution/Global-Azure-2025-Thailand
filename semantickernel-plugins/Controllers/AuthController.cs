using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace semantickernel_plugins;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtOptions _jwtOptions;
    private readonly ILogger<AuthController> _logger;
    private readonly AuthOptions _authOptions;

    public AuthController(
        ILogger<AuthController> logger,
        IOptions<JwtOptions> jwtOptions,
        IOptions<AuthOptions> authSettings)
    {
        _logger = logger;
        _jwtOptions = jwtOptions.Value;
        _authOptions = authSettings.Value;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        _logger.LogInformation("Login attempt from user: {Username}", login.Username);

        if (login.Username == _authOptions.AdminUser && login.Password == _authOptions.AdminPassword)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: new[] { new Claim(ClaimTypes.Name, login.Username) },
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );

            return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }

        return Unauthorized();
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Boulder.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HometController : ControllerBase
{
    private readonly ILogger<HometController> _logger;

    public HometController(ILogger<HometController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "HealthCheck")]
    public IActionResult Get()
    {
        return Ok("Alive");
    }
}

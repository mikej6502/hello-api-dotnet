using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "SayHello")]
    public string Get(string message)
    {
        _logger.LogInformation("Say Hello: " + message);
        return ">>" + message;
    }
}
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class SebaController : ControllerBase
{
    [HttpGet("Ping")]
    public string Ping()
    {
        return "Pong de dotnet.";
    }
}
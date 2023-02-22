using Microsoft.AspNetCore.Mvc;

namespace Instagram.Identity.API.Controllers;

[Route("api/v1/auth")]
public class TestController : ControllerBase
{
    [HttpGet("test")]
    public async Task<IActionResult> Test()
    {
        return Ok();
    }
}
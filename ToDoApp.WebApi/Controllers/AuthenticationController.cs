using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models.Dtos.Users.Requests;
using ToDoApp.Service.Abstracts;
namespace ToDoApp.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto dto)
    {
        var result = await authenticationService.LoginAsync(dto);
        return Ok(result);
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto dto)
    {
        var result = await authenticationService.RegisterAsync(dto);
        return Ok(result);
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Service.Abstracts;
using ToDoApp.Service.Concretes;
namespace ToDoApp.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    [HttpGet("email")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetByEmail([FromQuery] string email)
    {
        var result = await userService.GetByEmailAsync(email);
        return Ok(result);
    }
}

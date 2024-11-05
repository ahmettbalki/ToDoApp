using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
namespace ToDoApp.WebApi.Controllers;
public class CustomBaseController : ControllerBase
{
    public string GetUserId()
    {
        return HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
    }
}

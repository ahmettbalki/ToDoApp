﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ToDoApp.Models.Dtos.Todos.Requests;
using ToDoApp.Service.Abstracts;
namespace ToDoApp.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TodosController(ITodoService todoService) : ControllerBase
{
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = todoService.GetAll();
        return Ok(result);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CreateTodoRequest dto)
    {
        var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
        var result = todoService.Add(dto, userId);
        return Ok(result);
    }
    [HttpGet("getbyid/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        var result = todoService.GetById(id);
        return Ok(result);
    }
    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery] Guid id)
    {

        var result = todoService.Remove(id);
        return Ok(result);
    }
    [HttpPut("update")]
    public IActionResult Update([FromBody] UpdateTodoRequest dto)
    {
        var result = todoService.Update(dto);
        return Ok(result);
    }
}

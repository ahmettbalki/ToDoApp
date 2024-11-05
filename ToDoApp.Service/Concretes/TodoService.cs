using AutoMapper;
using Core.Responses;
using ToDoApp.DataAccess.Abstracts;
using ToDoApp.Models.Dtos.Todos.Requests;
using ToDoApp.Models.Dtos.Todos.Responses;
using ToDoApp.Models.Entities;
using ToDoApp.Service.Abstracts;
using ToDoApp.Service.Rules;
namespace ToDoApp.Service.Concretes;
public class TodoService(ITodoRepository todoRepository,
    IMapper mapper, TodoBusinessRules todoBusinessRules) : ITodoService
{
    public ReturnModel<TodoResponseDto> Add(CreateTodoRequest create, string userId)
    {
        var createdTodo = mapper.Map<Todo>(create);
        createdTodo.Id = Guid.NewGuid();
        todoRepository.Add(createdTodo);
        var response = mapper.Map<TodoResponseDto>(createdTodo);
        return new ReturnModel<TodoResponseDto>
        {
            Data = response,
            Message = "İş Eklendi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<List<TodoResponseDto>> GetAll()
    {
        var todos = todoRepository.GetAll();
        var responses = mapper.Map<List<TodoResponseDto>>(todos);
        return new ReturnModel<List<TodoResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<List<TodoResponseDto>> GetAllByCategoryId(int id)
    {
        throw new NotImplementedException();
    }
    public ReturnModel<TodoResponseDto?> GetById(Guid id)
    {
        var todo = todoRepository.GetById(id);
        todoBusinessRules.TodoIsNullCheck(todo);
        var response = mapper.Map<TodoResponseDto>(todo);
        return new ReturnModel<TodoResponseDto?>
        {
            Data = response,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<TodoResponseDto> Remove(Guid id)
    {
        var todo = todoRepository.GetById(id);
        var deletedTodo = todoRepository.Remove(todo);
        var response = mapper.Map<TodoResponseDto>(deletedTodo);
        return new ReturnModel<TodoResponseDto>
        {
            Data = response,
            Message = "İş Silindi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<TodoResponseDto> Update(UpdateTodoRequest updateTodo)
    {
        var todo = todoRepository.GetById(updateTodo.Id);
        var update = new Todo
        {
            CategoryId = todo.CategoryId,
            Completed = updateTodo.Completed,
            Description = updateTodo.Description,
            EndDate = updateTodo.EndDate,
            StartDate = updateTodo.StartDate,
            Priority = updateTodo.Priority,
            Title = updateTodo.Title,
            CreatedDate = todo.CreatedDate,
        };
        var updatedTodo = todoRepository.Update(update);
        var dto = mapper.Map<TodoResponseDto>(updatedTodo);
        return new ReturnModel<TodoResponseDto>
        {
            Data = dto,
            Message = "İş güncellendi",
            StatusCode = 200,
            Success = true
        };
    }
}

using Core.Responses;
using ToDoApp.Models.Dtos.Todos.Requests;
using ToDoApp.Models.Dtos.Todos.Responses;
namespace ToDoApp.Service.Abstracts;
public interface ITodoService
{
    ReturnModel<List<TodoResponseDto>> GetAll();
    ReturnModel<TodoResponseDto?> GetById(Guid id);
    ReturnModel<TodoResponseDto> Add(CreateTodoRequest create, string userId);
    ReturnModel<TodoResponseDto> Update(UpdateTodoRequest updateTodo);
    ReturnModel<TodoResponseDto> Remove(Guid id);
    ReturnModel<List<TodoResponseDto>> GetAllByCategoryId(int id);
}

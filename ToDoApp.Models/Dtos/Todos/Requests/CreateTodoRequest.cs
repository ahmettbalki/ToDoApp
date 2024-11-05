using ToDoApp.Models.Enums;
namespace ToDoApp.Models.Dtos.Todos.Requests;
public sealed record CreateTodoRequest(string Title,
    string Description,
    DateTime StartDate,
    DateTime EndDate,
    Priority Priority,
    int CategoryId,
    bool Completed,
    string UserId);
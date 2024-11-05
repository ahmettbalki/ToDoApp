using ToDoApp.Models.Enums;

namespace ToDoApp.Models.Dtos.Todos.Requests;
public sealed record UpdateTodoRequest(Guid Id,
    string Title,
    string Description,
    DateTime StartDate,
    DateTime EndDate,
    Priority Priority,
    int CategoryId,
    bool Completed,
    string UserId);
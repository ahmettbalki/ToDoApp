using AutoMapper;
using ToDoApp.Models.Dtos.Todos.Requests;
using ToDoApp.Models.Dtos.Todos.Responses;
using ToDoApp.Models.Entities;

namespace ToDoApp.Service.Profiles;
public class ToDoProfiles : Profile
{
    public ToDoProfiles()
    {
        CreateMap<Todo, TodoResponseDto>().ReverseMap();
        CreateMap<Todo, CreateTodoRequest>().ReverseMap();
        CreateMap<Todo, UpdateTodoRequest>().ReverseMap();
    }
}

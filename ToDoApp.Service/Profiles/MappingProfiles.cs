using AutoMapper;
using ToDoApp.Models.Dtos.Categories.Requests;
using ToDoApp.Models.Dtos.Categories.Responses;
using ToDoApp.Models.Dtos.Todos.Requests;
using ToDoApp.Models.Dtos.Todos.Responses;
using ToDoApp.Models.Entities;

namespace ToDoApp.Service.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Todo, TodoResponseDto>().ReverseMap();
        CreateMap<Todo, CreateTodoRequest>().ReverseMap();
        CreateMap<Todo, UpdateTodoRequest>().ReverseMap();
        CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CategoryResponseDto>().ReverseMap();
    }
}

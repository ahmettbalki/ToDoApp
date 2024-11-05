using AutoMapper;
using ToDoApp.Models.Dtos.Categories.Requests;
using ToDoApp.Models.Dtos.Categories.Responses;
using ToDoApp.Models.Entities;
namespace ToDoApp.Service.Profiles;
public class CategoryProfiles : Profile
{
    public CategoryProfiles()
    {
        CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
        CreateMap<Category, CreateCategoryRequest>().ReverseMap();
        CreateMap<Category, CategoryResponseDto>().ReverseMap();
    }
}

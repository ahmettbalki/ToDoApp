using AutoMapper;
using Core.Responses;
using ToDoApp.DataAccess.Abstracts;
using ToDoApp.Models.Dtos.Categories.Requests;
using ToDoApp.Models.Dtos.Categories.Responses;
using ToDoApp.Models.Entities;
using ToDoApp.Service.Abstracts;
namespace ToDoApp.Service.Concretes;
public class CategoryService(ICategoryRepository categoryRepository,
    IMapper mapper) : ICategoryService
{
    public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create)
    {
        var createdCategory = mapper.Map<Category>(create);
        categoryRepository.Add(createdCategory);
        var response = mapper.Map<CategoryResponseDto>(createdCategory);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Kategori Eklendi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<List<CategoryResponseDto>> GetAll()
    {
        var categories = categoryRepository.GetAll();
        var responses = mapper.Map<List<CategoryResponseDto>>(categories);
        return new ReturnModel<List<CategoryResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto?> GetById(int id)
    {
        var category = categoryRepository.GetById(id);
        var response = mapper.Map<CategoryResponseDto>(category);
        return new ReturnModel<CategoryResponseDto?>
        {
            Data = response,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto> Remove(int id)
    {
        var category = categoryRepository.GetById(id);
        var deletedCategory = categoryRepository.Remove(category);
        var response = mapper.Map<CategoryResponseDto>(deletedCategory);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Kategori Silindi.",
            StatusCode = 200,
            Success = true
        };
    }
    public ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest updateCategory)
    {
        var category = categoryRepository.GetById(updateCategory.Id);
        var update = new Category
        {
            Name = updateCategory.Name,
            CreatedDate = category.CreatedDate,
        };
        var updatedCategory = categoryRepository.Update(update);
        var dto = mapper.Map<CategoryResponseDto>(updatedCategory);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = dto,
            Message = "Kategori güncellendi",
            StatusCode = 200,
            Success = true
        };
    }
}

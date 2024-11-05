﻿using Core.Responses;
using ToDoApp.Models.Dtos.Categories.Requests;
using ToDoApp.Models.Dtos.Categories.Responses;
namespace ToDoApp.Service.Abstracts;
public interface ICategoryService
{
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<CategoryResponseDto?> GetById(int id);
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create);
    ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest updateCategory);
    ReturnModel<CategoryResponseDto> Remove(int id);
}
using Microsoft.Extensions.DependencyInjection;
using ToDoApp.Service.Abstracts;
using ToDoApp.Service.Concretes;
using ToDoApp.Service.Profiles;
using ToDoApp.Service.Rules;
namespace ToDoApp.Service;
public static class ServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfiles));
        services.AddScoped<TodoBusinessRules>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ITodoService, TodoService>();
        services.AddScoped<ICategoryService, CategoryService>();
        return services;
    }
}

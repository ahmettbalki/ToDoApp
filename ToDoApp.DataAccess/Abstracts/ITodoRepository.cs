using Core.Repositories;
using ToDoApp.Models.Entities;
namespace ToDoApp.DataAccess.Abstracts;
public interface ITodoRepository : IRepository<Todo, Guid>
{
}

using Core.Repositories;
using ToDoApp.DataAccess.Abstracts;
using ToDoApp.DataAccess.Contexts;
using ToDoApp.Models.Entities;
namespace ToDoApp.DataAccess.Concretes;
public class EfTodoRepository : EfRepositoryBase<BaseDbContext, Todo, Guid>, ITodoRepository
{
    public EfTodoRepository(BaseDbContext context) : base(context)
    {
    }
}

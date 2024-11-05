using Core.Entities;
namespace ToDoApp.Models.Entities;
public class Category : Entity<int>
{
    public string Name { get; set; }
    public List<Todo> Todos { get; set; }
}

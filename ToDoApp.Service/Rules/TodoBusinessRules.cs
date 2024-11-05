using Core.Exceptions;
using ToDoApp.Models.Entities;

namespace ToDoApp.Service.Rules;
public class TodoBusinessRules
{
    public virtual void TodoIsNullCheck(Todo todo)
    {
        if (todo is null)
            throw new NotFoundException("İlgili yapılacak iş bulunamadı.");
    }
}

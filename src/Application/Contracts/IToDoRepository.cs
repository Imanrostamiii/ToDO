using Application.Modeles.ToDos;

namespace Application.Contracts;

public interface IToDoRepository
{
    Task<Guid> CreatAsync(ToDoDto dto);
}
using Application.Contracts;
using Application.Modeles.ToDos;
using Infrastructure.persistence;

namespace Infrastructure.Repository;

public class ToDoRepository:IToDoRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ToDoRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public  async Task<Guid> CreatAsync(ToDoDto dto)
    {
        if (String.IsNullOrWhiteSpace(dto.Title))
        {
            throw new Exception("Title is Required");
        }

        var todo = new ToDo()
        {
            Title = dto.Title,
            Description = dto.Description

        };
        await _dbContext.ToDoS.AddAsync(todo);
        await _dbContext.SaveChangesAsync();
        return todo.Id;
    }
}
namespace Domin.Entites;

public class ToDoItem:BaseEntity
{
    public required String Title { get; set; }
    
    public Guid ToDoId { get; set; }

    public bool IsComplete { get; set; }

    public virtual ToDo ToDo { get; set; }
}
namespace Domin.Entites;

public class ToDo:BaseEntity
{
    public required String Title { get; set; }

    public String? Description { get; set; }

    public String? ImagPath { get; set; }

    public virtual IEnumerable<ToDoItem> ToDoItems { get; set; }
}
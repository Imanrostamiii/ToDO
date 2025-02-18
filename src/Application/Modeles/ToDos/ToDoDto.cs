using Microsoft.AspNetCore.Http;

namespace Application.Modeles.ToDos;

public class ToDoDto
{
    public required String Title { get; set; }

    public String? Description { get; set; }

    public IFormFile ImageFile { get; set; }
}
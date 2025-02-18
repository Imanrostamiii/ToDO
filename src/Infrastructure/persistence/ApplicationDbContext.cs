using System.Reflection;

namespace Infrastructure.persistence;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        
    }
    public DbSet<ToDo> ToDoS { get; set; }
    public DbSet<ToDoItem> ToDoItems { get; set; }
}
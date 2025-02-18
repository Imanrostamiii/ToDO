namespace Infrastructure.persistence.Configuration;

public class ToDoConfiguration:IEntityTypeConfiguration<ToDo>
{
    public void Configure(EntityTypeBuilder<ToDo> builder)
    {
        builder.ToTable("ToDO","ToDo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(300);
        
        builder.Property(x => x.Description)
            .IsRequired(false)
            .HasMaxLength(500);
        
        builder.Property(x => x.ImagPath)
            .IsRequired(false)
            .HasMaxLength(600);
    }
}
using Domin.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.persistence.Configuration;

public class ToDoItemConfiguration:IEntityTypeConfiguration<ToDoItem>
{
    public void Configure(EntityTypeBuilder<ToDoItem> builder)
    {
        builder.ToTable("ToDoItem", "ToDo");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(300);

        builder.HasOne(x => x.ToDo)
            .WithMany(x => x.ToDoItems)
            .HasForeignKey(x => x.ToDoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
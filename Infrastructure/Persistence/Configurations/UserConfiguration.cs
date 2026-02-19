using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("users");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnType("bigint");
        builder.Property(x => x.Name).HasColumnType("varchar(255)");
        builder.Property(x => x.Email).HasColumnType("varchar(255)");
        builder.Property(x => x.Password).HasColumnType("varchar(255)");
        builder.Property(x => x.Roles).HasColumnType("text");
        builder.Property(x => x.CreatedAt).HasColumnType("timestamp");
        builder.Property(x => x.UpdatedAt).HasColumnType("timestamp");

        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasIndex(x => x.Name);

        // Salvar data de criação apenas no insert
        builder
            .Property(x => x.CreatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAdd();

        // Salvar data de atualização apenas no update
        builder
            .Property(x => x.UpdatedAt)
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAddOrUpdate();
    }
}

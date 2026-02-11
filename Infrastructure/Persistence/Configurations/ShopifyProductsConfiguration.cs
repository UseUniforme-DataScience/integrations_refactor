using Domain.Entities.Shopify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ShopifyProductsConfiguration : IEntityTypeConfiguration<ShopifyProducts>
{
    public void Configure(EntityTypeBuilder<ShopifyProducts> builder)
    {
        builder.ToTable("shopify_products");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever().HasColumnType("bigint");
        builder.Property(x => x.Title).HasColumnType("varchar(255)");
        builder.Property(x => x.BodyHtml).HasColumnType("text");
        builder.Property(x => x.Vendor).HasColumnType("varchar(255)");
        builder.Property(x => x.ProductType).HasColumnType("varchar(50)");
        builder.Property(x => x.CreatedAt).HasColumnType("timestamp");
        builder.Property(x => x.Handle).HasColumnType("varchar(255)");
        builder.Property(x => x.UpdatedAt).HasColumnType("timestamp");
        builder.Property(x => x.PublishedAt).HasColumnType("timestamp");
        builder.Property(x => x.TemplateSuffix).HasColumnType("varchar(255)");
        builder.Property(x => x.PublishedScope).HasColumnType("varchar(50)");
        builder.Property(x => x.Tags).HasColumnType("text");
        builder.Property(x => x.Status).HasColumnType("varchar(255)");
        builder.Property(x => x.AdminGraphqlApiId).HasColumnType("varchar(255)");

        // Salvar data de criação
        builder
            .Property(x => x.InternalCreatedAt)
            .HasColumnType("timestamp")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAdd() // só gera no insert, não muda no update
            .IsRequired();

        // Data de atualização
        builder
            .Property(x => x.InternalUpdatedAt)
            .HasColumnType("timestamp")
            .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
            .ValueGeneratedOnAddOrUpdate() // gera no insert e atualiza automaticamente no update
            .IsRequired();

        // ===== JsonElement =====

        builder.Property(x => x.Variants).HasColumnType("text");
        builder.Property(x => x.Options).HasColumnType("text");
        builder.Property(x => x.Images).HasColumnType("text");
        builder.Property(x => x.Image).HasColumnType("text");

        // ===== Índices =====

        builder.HasIndex(x => x.AdminGraphqlApiId).IsUnique();
        builder.HasIndex(x => x.Handle);
        builder.HasIndex(x => x.Status);

        // Salvar data de criação
        builder
            .Property(x => x.InternalCreatedAt)
            .HasColumnType("timestamp")
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAdd() // só gera no insert, não muda no update
            .IsRequired();

        // Data de atualização
        builder
            .Property(x => x.InternalUpdatedAt)
            .HasColumnType("timestamp")
            .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
            .ValueGeneratedOnAddOrUpdate() // gera no insert e atualiza automaticamente no update
            .IsRequired();
    }
}

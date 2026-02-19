using Domain.Entities.Shopify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Shopify;

public class ShopifyCustomerConfiguration : IEntityTypeConfiguration<ShopifyCustomer>
{
    public void Configure(EntityTypeBuilder<ShopifyCustomer> builder)
    {
        builder.ToTable("shopify_customers");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedNever().HasColumnType("bigint");
        builder.Property(x => x.Cpf).HasColumnType("varchar(20)");
        builder.Property(x => x.CreatedAt).HasColumnType("timestamp");
        builder.Property(x => x.UpdatedAt).HasColumnType("timestamp");
        builder.Property(x => x.FirstName).HasColumnType("varchar(255)");
        builder.Property(x => x.LastName).HasColumnType("varchar(255)");
        builder.Property(x => x.OrdersCount).HasColumnType("int");
        builder.Property(x => x.State).HasColumnType("varchar(50)");
        builder.Property(x => x.TotalSpent).HasColumnType("varchar(20)");
        builder.Property(x => x.LastOrderId).HasColumnType("bigint");
        builder.Property(x => x.Note).HasColumnType("text");
        builder.Property(x => x.VerifiedEmail).HasColumnType("tinyint(1)");
        builder.Property(x => x.MultipassIdentifier).HasColumnType("varchar(255)");
        builder.Property(x => x.TaxExempt).HasColumnType("tinyint(1)");
        builder.Property(x => x.Tags).HasColumnType("text");
        builder.Property(x => x.LastOrderName).HasColumnType("varchar(100)");
        builder.Property(x => x.Email).HasColumnType("varchar(255)");
        builder.Property(x => x.Phone).HasColumnType("varchar(20)");
        builder.Property(x => x.Currency).HasColumnType("varchar(10)");
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
        builder.Property(x => x.Addresses).HasColumnType("text");
        builder.Property(x => x.TaxExemptions).HasColumnType("text");
        builder.Property(x => x.EmailMarketingConsent).HasColumnType("text");
        builder.Property(x => x.SmsMarketingConsent).HasColumnType("text");
        builder.Property(x => x.DefaultAddress).HasColumnType("text");

        // ===== Índices úteis =====
        builder.HasIndex(x => x.Email);
        builder.HasIndex(x => x.AdminGraphqlApiId).IsUnique();
    }
}

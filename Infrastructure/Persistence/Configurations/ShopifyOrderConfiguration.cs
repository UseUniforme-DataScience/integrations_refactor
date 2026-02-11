using Domain.Entities.Shopify;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ShopifyOrderConfiguration : IEntityTypeConfiguration<ShopifyOrder>
{
    public void Configure(EntityTypeBuilder<ShopifyOrder> builder)
    {
        builder.ToTable("shopify_orders");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).ValueGeneratedNever().HasColumnType("bigint");
        builder.Property(x => x.Cpf).HasColumnType("varchar(20)");

        // Índice para busca por CPF
        builder.HasIndex(x => x.Cpf);
        builder.Property(x => x.AdminGraphqlApiId).HasColumnType("varchar(255)");
        builder.Property(x => x.AppId).HasColumnType("bigint");
        builder.Property(x => x.BrowserIp).HasColumnType("varchar(255)");
        builder.Property(x => x.BuyerAcceptsMarketing).HasColumnType("tinyint(1)");
        builder.Property(x => x.CancelReason).HasColumnType("varchar(255)");
        builder.Property(x => x.CancelledAt).HasColumnType("timestamp");
        builder.Property(x => x.CartToken).HasColumnType("varchar(255)");
        builder.Property(x => x.CheckoutId).HasColumnType("bigint");
        builder.Property(x => x.CheckoutToken).HasColumnType("varchar(255)");
        builder.Property(x => x.ClosedAt).HasColumnType("timestamp");
        builder.Property(x => x.ConfirmationNumber).HasColumnType("varchar(255)");
        builder.Property(x => x.Confirmed).HasColumnType("tinyint(1)");
        builder.Property(x => x.ContactEmail).HasColumnType("varchar(255)");
        builder.Property(x => x.CreatedAt).HasColumnType("timestamp");
        builder.Property(x => x.Currency).HasColumnType("varchar(10)");
        builder.Property(x => x.CurrentSubtotalPrice).HasColumnType("varchar(20)");
        builder.Property(x => x.CurrentTotalDiscounts).HasColumnType("varchar(20)");
        builder.Property(x => x.CurrentTotalPrice).HasColumnType("varchar(20)");
        builder.Property(x => x.CurrentTotalTax).HasColumnType("varchar(20)");
        builder.Property(x => x.CustomerLocale).HasColumnType("varchar(255)");
        builder.Property(x => x.DeviceId).HasColumnType("bigint");
        builder.Property(x => x.DutiesIncluded).HasColumnType("tinyint(1)");
        builder.Property(x => x.Email).HasColumnType("varchar(255)");
        builder.Property(x => x.EstimatedTaxes).HasColumnType("tinyint(1)");
        builder.Property(x => x.FinancialStatus).HasColumnType("varchar(30)");
        builder.Property(x => x.FulfillmentStatus).HasColumnType("varchar(30)");
        builder.Property(x => x.LandingSite).HasColumnType("varchar(255)");
        builder.Property(x => x.LandingSiteRef).HasColumnType("varchar(255)");
        builder.Property(x => x.LocationId).HasColumnType("bigint");
        builder.Property(x => x.MerchantBusinessEntityId).HasColumnType("varchar(255)");
        builder.Property(x => x.MerchantOfRecordAppId).HasColumnType("bigint");
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Note).HasColumnType("text");
        builder.Property(x => x.Number).HasColumnType("bigint");
        builder.Property(x => x.OrderNumber).HasColumnType("bigint");
        builder.Property(x => x.OrderStatusUrl).HasColumnType("varchar(255)");
        builder.Property(x => x.Phone).HasColumnType("varchar(50)");
        builder.Property(x => x.PresentmentCurrency).HasColumnType("varchar(10)");
        builder.Property(x => x.ProcessedAt).HasColumnType("timestamp");
        builder.Property(x => x.Reference).HasColumnType("varchar(255)");
        builder.Property(x => x.ReferringSite).HasColumnType("varchar(255)");
        builder.Property(x => x.SourceIdentifier).HasColumnType("varchar(255)");
        builder.Property(x => x.SourceName).HasColumnType("varchar(255)");
        builder.Property(x => x.SourceUrl).HasColumnType("varchar(255)");
        builder.Property(x => x.SubtotalPrice).HasColumnType("varchar(20)");
        builder.Property(x => x.Tags).HasColumnType("text");
        builder.Property(x => x.TaxExempt).HasColumnType("tinyint(1)");
        builder.Property(x => x.TaxesIncluded).HasColumnType("tinyint(1)");
        builder.Property(x => x.Test).HasColumnType("tinyint(1)");
        builder.Property(x => x.Token).HasColumnType("varchar(50)");
        builder.Property(x => x.TotalDiscounts).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalLineItemsPrice).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalOutstanding).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalPrice).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalTax).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalTipReceived).HasColumnType("varchar(20)");
        builder.Property(x => x.TotalWeight).HasColumnType("int");
        builder.Property(x => x.UpdatedAt).HasColumnType("timestamp");
        builder.Property(x => x.UserId).HasColumnType("bigint");

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
        builder.Property(x => x.LineItems).HasColumnType("text");
        builder.Property(x => x.ClientDetails).HasColumnType("text");
        builder.Property(x => x.CurrentSubtotalPriceSet).HasColumnType("text");
        builder.Property(x => x.CurrentTotalAdditionalFeesSet).HasColumnType("text");
        builder.Property(x => x.CurrentTotalDiscountsSet).HasColumnType("text");
        builder.Property(x => x.CurrentTotalDutiesSet).HasColumnType("text");
        builder.Property(x => x.CurrentTotalPriceSet).HasColumnType("text");
        builder.Property(x => x.CurrentTotalTaxSet).HasColumnType("text");
        builder.Property(x => x.DiscountCodes).HasColumnType("text");
        builder.Property(x => x.NoteAttributes).HasColumnType("text");
        builder.Property(x => x.OriginalTotalAdditionalFeesSet).HasColumnType("text");
        builder.Property(x => x.OriginalTotalDutiesSet).HasColumnType("text");
        builder.Property(x => x.PaymentGatewayNames).HasColumnType("text");
        builder.Property(x => x.SubtotalPriceSet).HasColumnType("text");
        builder.Property(x => x.TaxLines).HasColumnType("text");
        builder.Property(x => x.TotalCashRoundingPaymentAdjustmentSet).HasColumnType("text");
        builder.Property(x => x.TotalCashRoundingRefundAdjustmentSet).HasColumnType("text");
        builder.Property(x => x.TotalDiscountsSet).HasColumnType("text");
        builder.Property(x => x.TotalLineItemsPriceSet).HasColumnType("text");
        builder.Property(x => x.TotalPriceSet).HasColumnType("text");
        builder.Property(x => x.TotalShippingPriceSet).HasColumnType("text");
        builder.Property(x => x.TotalTaxSet).HasColumnType("text");
        builder.Property(x => x.BillingAddress).HasColumnType("text");
        builder.Property(x => x.Customer).HasColumnType("text");
        builder.Property(x => x.DiscountApplications).HasColumnType("text");
        builder.Property(x => x.Fulfillments).HasColumnType("text");
        builder.Property(x => x.PaymentTerms).HasColumnType("text");
        builder.Property(x => x.Refunds).HasColumnType("text");
        builder.Property(x => x.ShippingAddress).HasColumnType("text");
        builder.Property(x => x.ShippingLines).HasColumnType("text");
    }
}

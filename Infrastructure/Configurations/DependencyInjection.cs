using Application.Interfaces.Bling;
using Application.Interfaces.Klaviyo;
using Application.Interfaces.Shopify;
using Application.Services.Bling;
using Application.Services.Klaviyo;
using Application.Services.Shopify;
using Domain.Interfaces.Repositories.Shopify;
using Infrastructure.Http.Bling;
using Infrastructure.Http.Klaviyo;
using Infrastructure.Http.Shopify;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories.Shopify;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        var mySqlConnectionString = new MySqlConnector.MySqlConnectionStringBuilder
        {
            Server = configuration["MySql:Host"],
            Port = uint.Parse(configuration["MySql:Port"] ?? "3306"),
            UserID = configuration["MySql:User"],
            Password = configuration["MySql:Password"],
            Database = configuration["MySql:Database"],
            SslMode = MySqlConnector.MySqlSslMode.Required,
            SslCa = configuration["MySql:CaCertPath"],
            SslCert = configuration["MySql:ClientCertPath"],
            SslKey = configuration["MySql:ClientKeyPath"],

            Pooling = true,
            MinimumPoolSize = 20,
            MaximumPoolSize = 120,
            ConnectionTimeout = 60,
            DefaultCommandTimeout = 60,
        }.ConnectionString;

        // DbContext principal (MySQL)
        services.AddDbContextPool<AppDbContext>(options =>
        {
            if (string.IsNullOrWhiteSpace(mySqlConnectionString))
            {
                throw new InvalidOperationException("MySQL connection string is invalid.");
            }
            options.UseMySql(mySqlConnectionString, new MySqlServerVersion(new Version(8, 4, 7)));
        });

        // Http clients / integrações externas
        services.AddShopifyClient(configuration);
        services.AddBlingTokenClient();
        services.AddBlingClient();
        services.AddKlaviyoClient();

        // Services
        //Bling
        services.AddSingleton<IBlingTokenService, BlingTokenService>();

        services.AddScoped<IBlingOrderService, BlingOrderService>();
        services.AddScoped<IBlingLogisticService, BlingLogisticService>();
        services.AddScoped<IBlingInvoiceService, BlingInvoiceService>();

        //Shopify
        services.AddScoped<IShopifyOrderService, ShopifyOrderService>();
        services.AddScoped<IShopifyProductService, ShopifyProductService>();
        services.AddScoped<IShopifyCustomerService, ShopifyCustomerService>();

        // Klaviyo
        services.AddScoped<IKlaviyoEventService, KlaviyoEventService>();

        // Repositories
        services.AddScoped<IShopifyOrderRepository, ShopifyOrderRepository>();

        return services;
    }
}

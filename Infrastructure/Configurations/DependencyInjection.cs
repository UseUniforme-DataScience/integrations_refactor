using Application.Interfaces.Bling;
using Application.Interfaces.Klaviyo;
using Application.Interfaces.Pipedrive;
using Application.Interfaces.Shopify;
using Application.Services.Bling;
using Application.Services.Klaviyo;
using Application.Services.Pipedrive;
using Application.Services.Shopify;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Repositories.Shopify;
using Infrastructure.Http.Bling;
using Infrastructure.Http.Klaviyo;
using Infrastructure.Http.Pipedrive;
using Infrastructure.Http.Shopify;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.Repositories.Shopify;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;

namespace Infrastructure.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        // MySQL
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
            MinimumPoolSize = 1, // mudar para 20
            MaximumPoolSize = 2, // mudar para 120
            ConnectionTimeout = 60,
            DefaultCommandTimeout = 60,
        }.ConnectionString;

        services.AddDbContextPool<AppDbContext>(options =>
        {
            if (string.IsNullOrWhiteSpace(mySqlConnectionString))
            {
                throw new InvalidOperationException("MySQL connection string is invalid.");
            }
            options.UseMySql(mySqlConnectionString, new MySqlServerVersion(new Version(8, 4, 7)));
        });

        // Redis
        var redisOptions = new ConfigurationOptions
        {
            EndPoints = { $"{configuration["Redis:Host"]}:{configuration["Redis:Port"]}" },
            Password = configuration["Redis:Password"],
            AbortOnConnectFail = false,
            AsyncTimeout = 5000,
            ConnectTimeout = 5000,
            ConnectRetry = 5,
            ClientName = "USE-INTEGRATIONS-REDIS",
            DefaultDatabase = 0,
        };

        services.AddSingleton<IConnectionMultiplexer>(_ =>
        {
            return ConnectionMultiplexer.Connect(redisOptions);
        });

        // Http clients / integrações externas
        // Shopify
        services.AddShopifyClient(configuration);
        // Bling
        services.AddBlingTokenClient();
        services.AddBlingClient();
        // Klaviyo
        services.AddKlaviyoClient();
        // Pipedrive
        services.AddPipedriveDealClient();
        services.AddPipedriveActivityClient();
        services.AddPipedriveNoteClient();
        services.AddPipedrivePersonClient();

        // Services
        // Redis
        services.AddSingleton<IRedisService, RedisService>();

        // Bling
        services.AddSingleton<IBlingTokenService, BlingTokenService>();

        services.AddScoped<IBlingOrderService, BlingOrderService>();
        services.AddScoped<IBlingLogisticService, BlingLogisticService>();
        services.AddScoped<IBlingInvoiceService, BlingInvoiceService>();

        // Shopify
        services.AddScoped<IShopifyOrderService, ShopifyOrderService>();
        services.AddScoped<IShopifyProductService, ShopifyProductService>();
        services.AddScoped<IShopifyCustomerService, ShopifyCustomerService>();

        // Klaviyo
        services.AddScoped<IKlaviyoEventService, KlaviyoEventService>();

        // Pipedrive
        services.AddScoped<IPipedriveDealService, PipedriveDealService>();
        services.AddScoped<IPipedriveNoteService, PipedriveNoteService>();
        services.AddScoped<IPipedriveActivityService, PipedriveActivityService>();
        services.AddScoped<IPipedrivePersonService, PipedrivePersonService>();

        // User
        services.AddScoped<IUserService, UserService>();

        // Token
        services.AddScoped<ITokenService, TokenService>();

        // Repositories
        // Shopify
        services.AddScoped<IShopifyOrderRepository, ShopifyOrderRepository>();
        // User
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}

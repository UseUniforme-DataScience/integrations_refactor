using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace Infrastructure.Persistence;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        // Carregar variáveis do .env (busca no diretório raiz do projeto)
        var rootPath = Path.Combine(Directory.GetCurrentDirectory(), "..");
        var envPath = Path.Combine(rootPath, ".env");
        if (File.Exists(envPath))
        {
            DotNetEnv.Env.Load(envPath);
        }

        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        var mySqlConnectionString = new MySqlConnector.MySqlConnectionStringBuilder
        {
            Server = config["MySql:Host"],
            Port = uint.Parse(config["MySql:Port"] ?? "3306"),
            UserID = config["MySql:User"],
            Password = config["MySql:Password"],
            Database = config["MySql:Database"],
            SslMode = MySqlConnector.MySqlSslMode.Required,
            SslCa = config["MySql:CaCertPath"],
            SslCert = config["MySql:ClientCertPath"],
            SslKey = config["MySql:ClientKeyPath"],
        }.ConnectionString;

        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseMySql(
            mySqlConnectionString,
            new MySqlServerVersion(new Version(8, 4, 7))
        );

        return new AppDbContext(optionsBuilder.Options);
    }
}

using DotNetEnv.Configuration;
using Infrastructure.Configurations;
using Infrastructure.Persistence;

// Carregar variáveis do arquivo .env
DotNetEnv.Env.Load("../.env");

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("System.Net.DisableIPv6", true);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Integrations API", Version = "v1" });
});

builder.Configuration.AddEnvironmentVariables();
builder.Configuration.AddDotNetEnv();
var config = builder.Configuration.AddJsonFile(
    "appsettings.json",
    optional: false,
    reloadOnChange: true
);

// ======================================================
// Infrastructure/ Dependencies injection
// ======================================================
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Integrations API v1"));

app.UseHttpsRedirection();

// pré criando conexão com o banco de dados
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await context.Database.CanConnectAsync();
}

app.MapControllers();

app.Run();

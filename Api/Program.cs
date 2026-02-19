using System.Text;
using DotNetEnv.Configuration;
using Infrastructure.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

// Carregar variáveis do arquivo .env
DotNetEnv.Env.Load("../.env");

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("System.Net.DisableIPv6", true);

// ======================================================
// Controllers
// ======================================================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// ======================================================
// Swagger
// =====================================================
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(
        "v1",
        new OpenApiInfo
        {
            Title = "CheckoutDF API",
            Version = "v1",
            Description = "API para o integração com o checkout do DF",
        }
    );

    // options.AddSecurityDefinition(
    //     "Bearer",
    //     new OpenApiSecurityScheme
    //     {
    //         Description = "JWT Authorization header. Use: Bearer {token}",
    //         Name = "Authorization",
    //         In = ParameterLocation.Header,
    //         Type = SecuritySchemeType.Http,
    //         Scheme = "bearer",
    //         BearerFormat = "JWT",
    //     }
    // );

    options.AddSecurityDefinition(
        "oauth2",
        new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.OAuth2,
            Flows = new OpenApiOAuthFlows
            {
                Password = new OpenApiOAuthFlow
                {
                    TokenUrl = new Uri("/api/Auth/swagger-login", UriKind.Relative),
                    Scopes = new Dictionary<string, string>(),
                },
            },
        }
    );

    options.AddSecurityRequirement(
        new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "oauth2",
                    },
                },
                new string[] { }
            },
        }
    );
});

// ======================================================
// Configuration
// ======================================================
builder.Configuration.AddEnvironmentVariables();
builder.Configuration.AddDotNetEnv();
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

// 🔐 Chave JWT (UTF8 correto)
var key = Encoding.UTF8.GetBytes(
    builder.Configuration["Authentication:PrivateKey"]
        ?? throw new InvalidOperationException("Private key is not configured")
);

// ======================================================
// Authentication
// ======================================================
builder
    .Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.MapInboundClaims = false; // evita mapeamento automático estranho

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ClockSkew = TimeSpan.Zero,
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),

            // 🔥 Como seu token usa "role"
            RoleClaimType = "role",
        };

        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
    });

// ======================================================
// Infrastructure DI
// ======================================================
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// ======================================================
// Swagger UI
// ======================================================
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Integrations API v1");
});

// ======================================================
// Middleware
// ======================================================
app.UseHttpsRedirection();

// ======================================================
// Authentication
// ======================================================
app.UseAuthentication();
app.UseAuthorization();

// ======================================================
// Controllers
// ======================================================
app.MapControllers();

// ======================================================
// Run
// ======================================================
app.Run();

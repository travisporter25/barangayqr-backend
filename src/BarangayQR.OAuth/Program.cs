using BarangayQR.OAuth.OAuthorization;
using BarangayQR.OAuth.SwaggerCustomUI;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(x =>
{
    x.DocumentFilter<BasePathFilter>();

    x.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert token",
        Name = "OAuthorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "OpenIddict",
        Scheme = "bearer"
    });
    x.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

builder.Services.AddAuthentication()
                .AddOAuthValidation("Bearer")
                .AddOpenIdConnectServer(options =>
                {
                    options.ProviderType = typeof(AuthorizationProvider);
                    options.AllowInsecureHttp = true;
                    options.TokenEndpointPath = new PathString("/oauth/token");
                    options.AccessTokenLifetime = TimeSpan.FromDays(30);
                    options.UseSlidingExpiration = true;
                });

builder.Services.AddScoped<AuthorizationProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

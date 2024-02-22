using AspNet.Security.OAuth.Validation;
using BarangayQR.OAuth.OAuthorization;
using BarangayQR.OAuth.SwaggerCustomUI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

if (builder.Environment.IsDevelopment())
{
    config.AddUserSecrets<Program>();
}

builder.Services.AddOptions();
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
        Name = "Authorization",
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

builder.Services.AddAuthentication(options => 
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddOAuthValidation()
                .AddOpenIdConnectServer(options =>
                {
                    options.ProviderType = typeof(AuthorizationProvider);
                    options.AllowInsecureHttp = true;
                    options.TokenEndpointPath = new PathString("/auth/token");
                    options.TokenEndpointPath = "/auth/token";
                    options.AccessTokenLifetime = TimeSpan.FromDays(7);
                    options.UseSlidingExpiration = true;
                });

builder.Services.AddScoped<AuthorizationProvider>();
builder.Services.AddAuthorization();
var sp = builder.Services.BuildServiceProvider();

builder.Services.AddDataProtection()
                .SetApplicationName("b@rAngay_qr")
                .AddKeyManagementOptions(o => o.XmlRepository = sp.GetService<IXmlRepository>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x =>
{
    x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials();
});

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();


app.Run();

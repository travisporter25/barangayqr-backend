using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Azure.Identity;
using Microsoft.Extensions.Configuration;
using BarangayQR.APIAPI.OptionSetup;
using BarangayQR.API.OptionSetup;
using BarangayQR.Core.Dapper;
using BarangayQR.API.Mappings;
using BarangayQR.Repository.Contract.Resident;
using BarangayQR.Repository.Resident;
using BarangayQR.API.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.OpenApi.Models;
using AspNet.Security.OAuth.Validation;
using BarangayQR.BarangayQR.Core;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.Repositories;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

if (builder.Environment.IsDevelopment())
{
    config.AddUserSecrets<Program>();
}

//if (builder.Environment.IsProduction())
//{
//    config.SetBasePath(Environment.CurrentDirectory)
//          .AddAzureKeyVault(new Uri(config.GetValue<string>("VaultUri")!), new DefaultAzureCredential())
//          .AddJsonFile("appsettings.json", true)
//          .AddEnvironmentVariables();
//}

builder.Services.AddOptions();
builder.Services.Configure<AppSettings>(config.GetSection("BarangayQR"));
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{

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

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//                .AddJwtBearer(option =>
//                              option.TokenValidationParameters = new TokenValidationParameters
//                              {
//                                  ValidateIssuer = true,
//                                  ValidateAudience = true,
//                                  ValidateLifetime = true,
//                                  ValidateIssuerSigningKey = true,
//                                  ValidIssuer = config["JwtSettings:Issuer"],
//                                  ValidAudience = config["JwtSettings:Audience"],
//                                  IssuerSigningKey = new SymmetricSecurityKey(
//                                  Encoding.UTF8.GetBytes(config["JwtSettings:Key"]!)),

//                              });

//builder.Services.ConfigureOptions<JWTSettingsOptionSetup>();

builder.Services.AddAuthentication(OAuthValidationDefaults.AuthenticationScheme)
                .AddOAuthValidation();

builder.Services.AddAuthorization();


#region Services
builder.Services.ConfigureDependencies();
#endregion

//if (builder.Environment.IsDevelopment())
//{
//    builder.Services.AddSwaggerGen();
//    builder.Services.ConfigureOptions<SwaggerGenOptionSetup>();
//}

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
    app.UseDeveloperExceptionPage();
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
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();

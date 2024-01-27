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

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

if (builder.Environment.IsDevelopment())
{
    config.AddUserSecrets<Program>();
}

if (builder.Environment.IsProduction())
{
    config.SetBasePath(Environment.CurrentDirectory)
          .AddAzureKeyVault(new Uri(config.GetValue<string>("VaultUri")!), new DefaultAzureCredential())
          .AddJsonFile("appsettings.json", true)
          .AddEnvironmentVariables();
}


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(option =>
                              option.TokenValidationParameters = new TokenValidationParameters
                              {
                                  ValidateIssuer = true,
                                  ValidateAudience = true,
                                  ValidateLifetime = true,
                                  ValidateIssuerSigningKey = true,
                                  ValidIssuer = config["JwtSettings:Issuer"],
                                  ValidAudience = config["JwtSettings:Audience"],
                                  IssuerSigningKey = new SymmetricSecurityKey(
                                  Encoding.UTF8.GetBytes(config["JwtSettings:Key"]!)),

                              });

builder.Services.ConfigureOptions<JWTSettingsOptionSetup>();

builder.Services.AddAuthorization();


#region Services

builder.Services.AddAutoMapper(typeof(DtoToDtoToDomainMapping));


builder.Services.AddTransient<IDapperConnection, AppDatabaseConnection>()
                .AddTransient<IAccountRepository, AccountRepository>();
#endregion

//if (builder.Environment.IsDevelopment())
//{
//    builder.Services.AddSwaggerGen();
//    builder.Services.ConfigureOptions<SwaggerGenOptionSetup>();
//}


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();

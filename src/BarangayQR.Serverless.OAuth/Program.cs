using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    config.AddUserSecrets<Program>();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace BarangayQRAPI.OptionSetup;

public class SwaggerGenOptionSetup : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        options.SwaggerDoc("v1", new OpenApiInfo { Title = "BarangayQR API", Version = "v1" });
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Scheme = "Bearer"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement()
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
                 In = ParameterLocation.Header, 
             },  
             new List<string>()
           }
        });
    }
}

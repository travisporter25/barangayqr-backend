using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BarangayQRAPI.Option;

namespace BarangayQRAPI.OptionSetup;

public class JWTBearerOptionSetup : IConfigureOptions<JwtBearerOptions>
{
    private readonly JWTSettingsOptions _JWTSettings;

    public JWTBearerOptionSetup(IOptions<JWTSettingsOptions> jWTSettings)
    {
        _JWTSettings = jWTSettings.Value;
    } 

    public void Configure(JwtBearerOptions options)
    {
        if (string.IsNullOrWhiteSpace(_JWTSettings.Key))
        {
            throw new Exception("No JWT settings key");
        }

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = _JWTSettings.Issuer,
            ValidAudience = _JWTSettings.Audience,
            IssuerSigningKey = new SymmetricSecurityKey(
             Encoding.UTF8.GetBytes(_JWTSettings.Key)),

        };
    }
}

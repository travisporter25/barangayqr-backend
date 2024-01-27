using Microsoft.Extensions.Options;
using BarangayQR.API.Option;

namespace BarangayQR.API.OptionSetup;

public class JWTSettingsOptionSetup : IConfigureOptions<JWTSettingsOptions>
{
    private const string SectionName = "JwtSettings";
    private readonly IConfiguration _configuration;

    public JWTSettingsOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(JWTSettingsOptions options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}
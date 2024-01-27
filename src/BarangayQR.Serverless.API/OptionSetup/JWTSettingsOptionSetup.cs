using Microsoft.Extensions.Options;
using BarangayQRAPI.Option;

namespace BarangayQRAPI.OptionSetup;

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
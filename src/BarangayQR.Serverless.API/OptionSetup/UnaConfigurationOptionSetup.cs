using Microsoft.Extensions.Options;
using BarangayQR.Entities;

namespace BarangayQRAPI.OptionSetup;

public class BarangayQRConfigurationOptionSetup : IConfigureOptions<BarangayQR.Entities.Config>
{
    private const string SectionName = "BarangayQRConfig";
    private readonly IConfiguration _configuration;

    public BarangayQRConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(Config options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

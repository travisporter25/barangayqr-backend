using Microsoft.Extensions.Options;
using BlobStorage.Entities;

namespace BarangayQR.API.OptionSetup;

public class ConfigurationOptionSetup : IConfigureOptions<Config>
{
    private const string SectionName = "BarangayQR.APIConfig";
    private readonly IConfiguration _configuration;

    public ConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(Config options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

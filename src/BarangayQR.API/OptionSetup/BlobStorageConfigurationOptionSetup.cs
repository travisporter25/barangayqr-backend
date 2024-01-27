using Microsoft.Extensions.Options;
using BlobStorage.Entities;

namespace BarangayQR.API.OptionSetup;

public class BlobStorageConfigurationOptionSetup : IConfigureOptions<Config>
{
    private const string SectionName = "AzureBlobStorageConfig";
    private readonly IConfiguration _configuration;

    public BlobStorageConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(Config options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

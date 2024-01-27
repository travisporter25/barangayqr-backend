using Microsoft.Extensions.Options;
using BarangayQR.Entities;

namespace BarangayQRAPI.OptionSetup;

public class AzureBlobStorageConfigurationOptionSetup : IConfigureOptions<AzureBlobStorage.Entities.Config>
{
    private const string SectionName = "AzureBlobStorageConfig";
    private readonly IConfiguration _configuration;

    public AzureBlobStorageConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(AzureBlobStorage.Entities.Config options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

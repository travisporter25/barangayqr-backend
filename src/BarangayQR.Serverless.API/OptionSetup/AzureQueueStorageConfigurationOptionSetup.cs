using AzureBlobStorage.Entities;
using Microsoft.Extensions.Options;
using BarangayQR.Entities;

namespace BarangayQRAPI.OptionSetup;

public class AzureQueueStorageConfigurationOptionSetup : IConfigureOptions<QueueConfig>
{
    private const string SectionName = "AzureQueueStorageConfig";
    private readonly IConfiguration _configuration;

    public AzureQueueStorageConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(QueueConfig options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

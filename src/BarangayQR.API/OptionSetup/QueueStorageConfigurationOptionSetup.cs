
using Microsoft.Extensions.Options;
using BlobStorage.Entities;

namespace BarangayQR.APIAPI.OptionSetup;

public class QueueStorageConfigurationOptionSetup : IConfigureOptions<QueueConfig>
{
    private const string SectionName = "AzureQueueStorageConfig";
    private readonly IConfiguration _configuration;

    public QueueStorageConfigurationOptionSetup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(QueueConfig options)
    {
        _configuration.GetSection(SectionName).Bind(options);
    }
}

using Core.Queues;
using Azure.Storage.Queues;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace BlobStorage.Queues;

public class AzureQueueDispatcher : IQueueDispatcher
{

    private readonly string _ConnectionString;
    private readonly static QueueClientOptions _QueueOption = new()
    {
        MessageEncoding = QueueMessageEncoding.Base64
    };

    public AzureQueueDispatcher(IOptions<Entities.QueueConfig> configuration)
    {
        if (string.IsNullOrWhiteSpace(configuration.Value.ConnectionString))
        {
            throw new Exception("Invalid ConnectionString");
        }

        _ConnectionString = configuration.Value.ConnectionString;

    }

    public AzureQueueDispatcher(Entities.QueueConfig config)
    {
        if (string.IsNullOrWhiteSpace(config.ConnectionString))
        {
            throw new Exception("Invalid ConnectionString");
        }

        _ConnectionString = config.ConnectionString;

    }

    public async Task<bool> SendToQueue(string QueueName, string QueueMessage)
    {
        if (string.IsNullOrWhiteSpace(QueueName) || QueueName.Any(char.IsUpper))
        {
            throw new Exception($"Invalid QueueName");
        }

        if (string.IsNullOrWhiteSpace(QueueMessage))
        {
            throw new Exception($"Invalid QueueMessage");
        }

        var queue = new QueueClient(_ConnectionString, QueueName, _QueueOption);

        await queue.CreateIfNotExistsAsync();

        await queue.SendMessageAsync(QueueMessage);

        return true;

    }

    public string ToMessage(object model)
    {
        var Message = JsonConvert.SerializeObject(model);
        return Message;
    }
}

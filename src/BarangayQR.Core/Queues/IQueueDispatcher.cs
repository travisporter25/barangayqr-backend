namespace BarangayQR.Core.Queues;

public interface IQueueDispatcher
{
    public Task<bool> SendToQueue(string QueueName, string QueueMessage);

    public string ToMessage(object model);
}

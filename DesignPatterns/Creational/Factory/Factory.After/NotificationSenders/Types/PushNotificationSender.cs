namespace Factory.After.NotificationSenders.Types;

internal class PushNotificationSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        // Implementation for sending push notification
        Console.WriteLine($"Push notification sent to {recipient}: {message}");
    }
}

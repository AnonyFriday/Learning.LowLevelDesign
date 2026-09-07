namespace Factory.After.NotificationSenders.Types;

internal class SmsNotificationSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        // Implementation for sending SMS notification
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}
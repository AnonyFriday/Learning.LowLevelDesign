namespace Factory.After.NotificationSenders.Types;

internal class EmailNotificationSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        // Implementation for sending email notification
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}

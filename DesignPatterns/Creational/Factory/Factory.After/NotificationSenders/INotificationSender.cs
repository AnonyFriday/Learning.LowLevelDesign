namespace Factory.After.NotificationSenders;

internal interface INotificationSender
{
    public void Send(string recipient, string message);
}

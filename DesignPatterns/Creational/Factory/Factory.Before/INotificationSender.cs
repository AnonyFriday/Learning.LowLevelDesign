namespace Factory.Before;

internal interface INotificationSender
{
    public void Send(string recipient, string message);
}
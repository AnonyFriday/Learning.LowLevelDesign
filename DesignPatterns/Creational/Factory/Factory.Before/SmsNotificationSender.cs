namespace Factory.Before;

internal class SmsNotificationSender : INotificationSender
{
    public void Send(string recipient, string message)
    {
        throw new NotImplementedException();
    }
}

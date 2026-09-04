using SOLID.L.Before;

public interface INotificationService
{
    public void SendSms(Sms sms);
    public void SendEmail(Email email);
}
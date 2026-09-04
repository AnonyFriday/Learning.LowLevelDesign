namespace SOLID.L.Before;

internal class VinaphoneNotificationService : INotificationService
{
    // Since the substype does not support sending Email, we do not implement the behavior in here
    public void SendEmail(Email email)
    {
        throw new NotImplementedException();
    }

    public void SendSms(Sms sms)
    {
        Console.WriteLine($"Sending SMS to {sms.To} from {sms.From} with message '{sms.Message}'");
    }
}
namespace SOLID.I.After;

internal class VinaphoneNotificationService : ISmsNotificationService
{
    public void SendSms(Sms sms)
    {
        Console.WriteLine($"Sending SMS to {sms.To} from {sms.From} with message '{sms.Message}'");
    }
}

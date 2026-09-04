namespace SOLID.L.Before;

// Azure support both Email and SMS
public class AzureNotificationService : INotificationService
{
    public void SendEmail(Email email)
    {
        Console.WriteLine($"Sending Email to {email.To} from {email.From} with subject '{email.Subject}' and body '{email.Body}'");
    }

    public void SendSms(Sms sms)
    {
        Console.WriteLine($"Sending SMS to {sms.To} from {sms.From} with message '{sms.Message}'");
    }
}
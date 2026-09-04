namespace SOLID.I.Before;

public class AwsNotificationService : INotificationService
{
    public void SendEmail(Email email)
    {
        Console.WriteLine($"Sending Email to {email.To} from {email.From} with subject '{email.Subject}' and body '{email.Body}'");
    }

    // Since the substype does not support sending SMS, we do not implement the behavior in here
    public void SendSms(Sms sms)
    {
        throw new NotImplementedException();
    }
}

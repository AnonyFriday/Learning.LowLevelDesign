namespace SOLID.L.After;

public class AwsNotificationService : IEmailNotificationService
{
    public void SendEmail(Email email)
    {
        Console.WriteLine($"Sending Email to {email.To} from {email.From} with subject '{email.Subject}' and body '{email.Body}'");
    }
}
namespace SOLID.L.Before;

public class UserService
{
    private readonly INotificationService _notificationService;

    public UserService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    // What happen if we registered service but don't have the SendEmail implementation(Vinaphone)
    public void RegisterUser(string email, string phoneNumber)
    {
        // Logic to register the user (e.g., save to database)

        // Send notification
        _notificationService.SendEmail(new Email("", "", "", ""));
    }

    // What happen if we registered service but don't have the SendSms implementation(Aws)
    public void SendOtp(string phoneNumber)
    {
        // Logic to generate OTP

        // Send OTP via SMS
        _notificationService.SendSms(new Sms("", "", ""));
    }
}
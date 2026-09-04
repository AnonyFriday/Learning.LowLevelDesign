namespace SOLID.I.After;

internal class UserService
{
    private readonly IEmailNotificationService _emailNotificationService;
    private readonly ISmsNotificationService _smsNotificationService;

    public UserService(IEmailNotificationService emailNotificationService, ISmsNotificationService smsNotificationService)
    {
        _emailNotificationService = emailNotificationService;
        _smsNotificationService = smsNotificationService;
    }

    public void RegisterUser(string email, string phoneNumber)
    {
        // Logic to register the user (e.g., save to database)

        // Send notification
        _emailNotificationService.SendEmail(new Email("", "", "", ""));
    }

    public void SendOtp(string phoneNumber)
    {
        // Logic to generate OTP

        // Send OTP via SMS
        _smsNotificationService.SendSms(new Sms("", "", ""));
    }
}

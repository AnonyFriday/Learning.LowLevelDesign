namespace SOLID.D.Before;

internal class UserService(SmtpNotificationService smtpNotificationService)
{
    // What happen if we use the different protocol to send email, and decide to switch 1 day:
    // - SMTP
    // - POP3
    // - IMAP
    public void RegisterUser(User user)
    {
        // Logic to register user
        var message = "Welcome to our service!";
        smtpNotificationService.SendEmail(new Email(user.Email, "Welcome!", message));
    }
}
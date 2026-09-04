namespace SOLID.D.After;

internal class UserService(IEmailNotificationService emailNotificationService)
{
    public void RegisterUser(User user)
    {
        // Logic to register user
        var message = "Welcome to our service!";
        emailNotificationService.SendEmail(new Email(user.Email, "Welcome!", message));
    }
}
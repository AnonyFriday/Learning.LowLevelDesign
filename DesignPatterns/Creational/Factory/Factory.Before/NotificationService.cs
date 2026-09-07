namespace Factory.Before;

/*
    Violate the Open/Close Principle because if another type of the payment raised, we have to 
    modify the NotificationService class to add another case in the switch statement.
    Eventhough each class has its own implementation.

    NotificationService class also vipolate SRP:
    - Create objects of different types of notification senders
    - Send the notification to the recipient using the created object

    Solution:
    - Apply a Factory pattern for object creation
*/
public class NotificationService
{
    public void RunMigration(NotificationChannelType migrationType, string recipient, string message)
    {
        INotificationSender sender;

        switch (migrationType)
        {
            case NotificationChannelType.Email:
                sender = new EmailNotificationSender();
                break;
            case NotificationChannelType.SMS:
                sender = new SmsNotificationSender();
                break;
            case NotificationChannelType.PushNotification:
                sender = new PushNotificationSender();
                break;
            case NotificationChannelType.Slack:
                sender = new SlackNotificationSender();
                break;
            default:
                throw new ArgumentException("Invalid migration type");
        }

        sender.Send(recipient, message);

    }
}
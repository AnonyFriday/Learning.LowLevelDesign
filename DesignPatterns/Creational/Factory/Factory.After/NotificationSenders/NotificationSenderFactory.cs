using Factory.After.NotificationSenders.Types;

namespace Factory.After.NotificationSenders;

internal class NotificationSenderFactory : INotificationSenderFactory
{
    public INotificationSender CreateSender(NotificationSenderType notificationSenderType)
    {
        return notificationSenderType switch
        {
            NotificationSenderType.Email => new EmailNotificationSender(),
            NotificationSenderType.SMS => new SmsNotificationSender(),
            NotificationSenderType.PushNotification => new PushNotificationSender(),
            _ => throw new ArgumentException("Invalid notification sender type")
        };
    }
}
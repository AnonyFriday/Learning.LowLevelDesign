using Factory.After.NotificationSenders.Types;

namespace Factory.After.NotificationSenders;

// Could be abstract class or interface, 
// - If sharing the common state and behavior, then use abstract class
// - If only sharing the contract, then use interface
internal interface INotificationSenderFactory
{
    // Factory method, responsible for creating the appropriate notification sender based on the type
    public INotificationSender CreateSender(NotificationSenderType notificationSenderType);
}

using Factory.After.NotificationSenders;
using Factory.After.NotificationSenders.Types;

namespace Factory.After;

internal class PaymentService(
    INotificationSenderFactory notificationSenderFactory
)
{
    public Response Handler(Request orgRequest)
    {
        // Validation
        var request = orgRequest with { NotificationChannelType = orgRequest.NotificationChannelType };
        // Cleaning
        // ...
        // Business Logic for calculation
        // ...
        // Notifiy to user
        var notificationSender = notificationSenderFactory.CreateSender(request.NotificationChannelType);
        notificationSender.Send(request.customerName.ToString(), "Payment processed successfully.");

        // Return response 
        return new Response("Payment processed successfully.");
    }
}

internal record Request(int total, int customerName, int currentcy, NotificationSenderType NotificationChannelType);

internal record Response(string message);

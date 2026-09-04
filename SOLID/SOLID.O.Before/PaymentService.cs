namespace SOLID.O.Before;

public class PaymentService
{
    public void Pay(Guid orderId, PaymentMethod paymentMethod)
    {
        // Get Orders
        // OrderService orderService = new OrderService();
        // var order = orderService.GetOrder(orderId);
        // var paymentMethod = order.PaymentMethod;

        switch (paymentMethod)
        {
            case PaymentMethod.Cash:
                // Process credit card payment
                break;
            case PaymentMethod.DebitCard:
                // Process debit card payment
                break;
            case PaymentMethod.PayPal:
                // Process PayPal payment
                break;
            case PaymentMethod.Unknown:
            default:
                break;
        }

        // Update order status
        // Save Result to database
    }
}
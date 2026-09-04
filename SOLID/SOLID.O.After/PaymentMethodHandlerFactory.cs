using SOLID.O.After;
using SOLID.O.After.Cash;
using SOLID.O.After.DebitCard;
using SOLID.O.After.PayPal;
using SOLID.O.After.Unknown;

public class PaymentMethodHandlerFactory : IPaymentMethodHandlerFactory
{
    public IPaymentMethodHandler GetPaymentMethodHandler(PaymentMethod paymentMethod)
    {
        // Traditional Switch Statement
        // switch (paymentMethod)
        // {
        //     case PaymentMethod.Cash:
        //         return new CashPaymentMethodHandler();
        //     case PaymentMethod.DebitCard:
        //         return new DebitCardPaymentMethodHandler();
        //     case PaymentMethod.PayPal:
        //         return new PayPalPaymentMethodHandler();
        //     case PaymentMethod.Unknown:
        //     default:
        //         return new UnknownPaymentMethodHandler();
        // }

        // Using Pattern Matching
        return paymentMethod switch
        {
            PaymentMethod.Cash => new CashPaymentMethodHandler(),
            PaymentMethod.DebitCard => new DebitCardPaymentMethodHandler(),
            PaymentMethod.PayPal => new PayPalPaymentMethodHandler(),
            PaymentMethod.Unknown => new UnknownPaymentMethodHandler(),
            _ => new UnknownPaymentMethodHandler()
        };
    }
}
namespace SOLID.O.After;

/*
    Factory Pattern
    - generate the corresponding class derived from the same interface base on the enum argument
*/
public interface IPaymentMethodHandlerFactory
{
    IPaymentMethodHandler GetPaymentMethodHandler(PaymentMethod paymentMethod);
}
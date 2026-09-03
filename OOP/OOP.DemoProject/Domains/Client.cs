using OOP.DemoProject.Interfaces;
using OOP.DemoProject.Services;

namespace OOP.DemoProject.Domains;

public class Client(PaymentService paymentService)
{
    public void AddPaymentMethod(string methodName, IPaymentMethod paymentMethod)
    {
        paymentService.AddPaymentMethod(methodName, paymentMethod);
    }

    public void MakePayment(string methodName)
    {
        paymentService.MakePayment(methodName);
    }
}
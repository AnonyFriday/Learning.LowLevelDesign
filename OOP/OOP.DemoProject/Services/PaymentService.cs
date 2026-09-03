using OOP.DemoProject.Domains;
using OOP.DemoProject.Interfaces;

namespace OOP.DemoProject.Services;

// Storing and Making payments using different payment methods
public class PaymentService
{
    private readonly Dictionary<string, IPaymentMethod> _paymentMethods;

    public PaymentService()
    {
        _paymentMethods = new Dictionary<string, IPaymentMethod>();
    }

    public void AddPaymentMethod(string methodName, IPaymentMethod paymentMethod)
    {
        if (methodName == null || paymentMethod == null)
        {
            Console.WriteLine("Method name and payment method cannot be null.");
            return;
        }

        _paymentMethods.Add(methodName, paymentMethod);
    }

    public void MakePayment(string methodName)
    {
        if (!_paymentMethods.TryGetValue(methodName, out IPaymentMethod? paymentMethod))
        {
            Console.WriteLine($"Payment method '{methodName}' not found.");
        }
        else
        {
            paymentMethod.Pay(100); // Run Time Polymorphism - The actual implementation of Pay will be determined at runtime based on the type of paymentMethod
        }
    }

    public void DisplayAllCardBenefits()
    {
        foreach (var cardMethod in _paymentMethods.Values)
        {
            if (cardMethod is Card card)
            {
                Console.WriteLine();
                card.AbstractDisplayCardBenefit();
                card.VirtualDisplayCardLoyaltyRate();
                card.NonVirtualDisplayCardLoyaltyRate();
                card.DisplayCardDetails();
                card.DisplayCardDetails("Anony");
                Console.WriteLine();
            }
        }
    }
}
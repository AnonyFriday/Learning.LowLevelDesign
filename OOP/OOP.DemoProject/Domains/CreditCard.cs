using OOP.DemoProject.Interfaces;

namespace OOP.DemoProject.Domains;

public class CreditCard(string cardNo, string userName) : Card(cardNo, userName), IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by Credit Card");
    }

    public override void AbstractDisplayCardBenefit()
    {
        Console.WriteLine("Credit Card Benefit: Cashback on purchases.");
    }

    public override void VirtualDisplayCardLoyaltyRate()
    {
        Console.WriteLine("Credit Card Loyalty Rate: 2%");
    }

    // Inheritance - Member Hiding (Shadowing) with 'new' keyword to avoid naming conflicts with base class
    public new void NonVirtualDisplayCardLoyaltyRate()
    {
        Console.WriteLine("Credit Card Loyalty Rate: 200%");
    }
}
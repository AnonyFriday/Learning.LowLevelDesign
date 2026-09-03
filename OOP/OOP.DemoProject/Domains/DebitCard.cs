using OOP.DemoProject.Interfaces;

namespace OOP.DemoProject.Domains;

public class DebitCard(string cardNo, string userName) : Card(cardNo, userName), IPaymentMethod
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by Debit Card");
    }

    public override void AbstractDisplayCardBenefit()
    {
        Console.WriteLine("Debit Card Benefit: No annual fee.");
    }
}
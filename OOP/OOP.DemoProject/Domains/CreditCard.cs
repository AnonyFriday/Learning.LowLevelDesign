using OOP.DemoProject.Interfaces;

namespace OOP.DemoProject.Domains
{
    public class CreditCard(string cardNo, string userName) : Card(cardNo, userName), IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by Credit Card");
        }

        public override void DisplayCardBenefit()
        {
            Console.WriteLine("Credit Card Benefit: Cashback on purchases.");
        }

        public override void DisplayCardLoyaltyRate()
        {
            Console.WriteLine("Credit Card Loyalty Rate: 2%");
        }
    }
}
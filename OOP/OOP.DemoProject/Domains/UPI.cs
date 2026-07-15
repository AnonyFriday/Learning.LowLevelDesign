using OOP.DemoProject.Interfaces;

namespace OOP.DemoProject.Domains
{
    public class UPI(string upiId) : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} by UPI ID: {upiId}");
        }
    }
}
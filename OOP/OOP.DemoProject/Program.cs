namespace OOP.DemoProject;

class Program
{
    static void Main(string[] args)
    {
        var paymentService = new Services.PaymentService();
        var client = new Domains.Client(paymentService);

        // Adding payment methods
        client.AddPaymentMethod("CreditCard", new Domains.CreditCard("1234-5678-9012-3456", "John Doe"));
        client.AddPaymentMethod("UPI", new Domains.UPI("john.doe@upi"));
        client.AddPaymentMethod("PayPal", new Domains.DebitCard("9876-5432-1098-7654", "John Doe"));

        // Making payments
        client.MakePayment("CreditCard");
        client.MakePayment("UPI");
    }
}

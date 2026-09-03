namespace OOP.DemoProject;

internal class Program
{
    protected Program()
    {
    }

    static void Main(string[] args)
    {
        var paymentService = new Services.PaymentService();
        var client = new Domains.Client(paymentService);

        // Adding payment methods
        Console.WriteLine("======== Adding payment methods... ======== ");
        client.AddPaymentMethod("CreditCard", new Domains.CreditCard("1234-5678-9012-3456", "John Doe"));
        client.AddPaymentMethod("UPI", new Domains.Upi("john.doe@upi"));
        client.AddPaymentMethod("PayPal", new Domains.DebitCard("9876-5432-1098-7654", "John Doe"));

        // Making payments
        Console.WriteLine("======== Making Payments... ======== ");
        client.MakePayment("CreditCard");
        client.MakePayment("UPI");

        // Displaying card benefits
        Console.WriteLine("======== Cards ======== ");
        paymentService.DisplayAllCardBenefits();
    }
}

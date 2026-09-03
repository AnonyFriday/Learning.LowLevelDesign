namespace OOP.DemoProject.Interfaces;

// Abstraction - Interface define contracts, the implementation wont be provided
public interface IPaymentMethod
{
    void Pay(decimal amount);
}
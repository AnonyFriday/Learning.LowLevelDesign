namespace OOP.DemoProject.Domains;

public abstract class Card(string cardNo, string userName)
{
    // Encapsulation - Backing Fields with Properties, Modifiers
    private string _cardNo = cardNo;
    private string _userName = userName;
    public string CardNo { get => _cardNo; set => _cardNo = value; }
    public string UserName { get => _userName; set => _userName = value; }

    // Encapsulation - Auto-Implemented Properties
    public string CardType { get; set; } = "Default Card Type";

    // Abstraction - Abstract method to be implemented by derived classes
    public abstract void AbstractDisplayCardBenefit();

    // Polymorphism - Method Overriding / Runtime Polymorphism
    public virtual void VirtualDisplayCardLoyaltyRate()
    {
        Console.WriteLine($"Virtual Card Loyalty Rate: 1%"); // Default loyalty rate
    }

    public void NonVirtualDisplayCardLoyaltyRate()
    {
        Console.WriteLine($"Non-virtual Card Loyalty Rate: 1%"); // Default loyalty rate
    }

    // Polymorphism - Method Overloading/ Compiletime Polymorphism
    public void DisplayCardDetails()
    {
        Console.WriteLine($"Card Number: {CardNo}, User Name: {UserName}");
    }

    public void DisplayCardDetails(string invitedBy)
    {
        Console.WriteLine($"Card Number: {CardNo}, User Name: {UserName} invited by {invitedBy}");
    }
}
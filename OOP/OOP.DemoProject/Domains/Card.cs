namespace OOP.DemoProject.Domains
{
    public abstract class Card(string cardNo, string userName)
    {
        private string _cardNo = cardNo;
        private string _userName = userName;

        // Encapsulation - Getter and Setters or Property
        public string CardNo { get => _cardNo; set => _cardNo = value; }
        public string UserName { get => _userName; set => _userName = value; }

        // Polymorphism - Method Overloading
        public void DisplayCardDetails()
        {
            Console.WriteLine($"Card Number: {CardNo}, User Name: {UserName}");
        }

        public void DisplayCardDetails(string invitedBy)
        {
            Console.WriteLine($"Card Number: {CardNo}, User Name: {UserName} invited by {invitedBy}");
        }

        // Abstraction - Abstract method to be implemented by derived classes
        public abstract void DisplayCardBenefit();

        // Abstraction 0 Virtual method that can be overridden by derived classes
        public virtual void DisplayCardLoyaltyRate()
        {
            Console.WriteLine($"Card Loyalty Rate: 1%"); // Default loyalty rate
        }
    }
}
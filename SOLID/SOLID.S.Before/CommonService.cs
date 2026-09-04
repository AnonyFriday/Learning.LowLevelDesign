namespace SOLID.S.Before;

internal class CommonService
{
    void AddUser(User user) { }
    void UpdateUser(User oldUser, User newUser) { }
    void DeleteUser(string id) { }
    void AddCustomer(Customer customer) { }
    void UpdateCustomer(Customer oldCustomer, Customer newCustomer) { }
    void SendMessage(string fromEmail, string body, string toEmail, string fromNumber, string toNumber, string message)
    {
        if (!string.IsNullOrEmpty(fromEmail) && !string.IsNullOrEmpty(toEmail))
        {
            // Send email
        }

        // Send sms
    }
}
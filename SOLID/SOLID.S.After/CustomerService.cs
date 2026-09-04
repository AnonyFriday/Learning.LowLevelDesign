namespace SOLID.S.After;

/*
    The class contains too many responsibilities. (Sms Service, Email Service, User Service, Customer Service)
    A class should have only one reason to change.
    
*/
internal class CustomerService
{
    void AddCustomer(Customer customer) { }
    void UpdateCustomer(Customer oldCustomer, Customer newCustomer) { }
}
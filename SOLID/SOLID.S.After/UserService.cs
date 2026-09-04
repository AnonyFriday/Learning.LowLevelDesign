namespace SOLID.S.After;

internal class UserService
{
    void AddUser(User user)
    {
        // 1. Validation

        // 2. Request Cleaning

        // 3. Inject Repository to call the connection to Database
        UserRepository userRepository = new UserRepository();
        userRepository.AddUser(user);

        // 4. Mapping Request to Response
    }

    void UpdateUser(User oldUser, User newUser) { }
    void DeleteUser(string id) { }
}
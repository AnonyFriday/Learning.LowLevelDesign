using SOLID.D.After;

// Today we will use the Smtp to send email
var userService = new UserService(new SmtpNotificationService());

// One day we changes, we use the Pop3 to send email
userService = new UserService(new Pop3NotificationService());
userService.RegisterUser(new User("John Doe", "john.doe@example com"));
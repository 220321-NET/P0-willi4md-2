using Models;

// Instantiate a default user and begin the login menu screen.
User begin = new User();
User user = begin.LoginMenu();
Console.WriteLine("=========================================");
Console.WriteLine("      Welcome back, " + user.getUsername() + "!");
Console.WriteLine("=========================================" + "\n");

// Instantiate the options menu and await user input.
Options optionsMenu = new Options();
optionsMenu.OpenOptionsMenu();


// Close Program
Console.WriteLine("Goodbye!");


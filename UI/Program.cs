using Models;
// Instantiate a default user and begin the login menu screen.
User begin = new User();
User user = begin.LoginMenu();

Console.WriteLine("=========================================");
Console.WriteLine("         Welcome back, " + user.getUsername() + "!");
Console.WriteLine("=========================================" + "\n");

// Instantiate the options menu and await user input.

if (user.getUsername() != "admin") {
    Options optionsMenu = new Options();
    optionsMenu.OpenOptionsMenu();
} else {
    AdminOptions adminMenu = new AdminOptions();
    adminMenu.OpenOptionsMenu();
}


// Close Program
Console.WriteLine("=========================================");
Console.WriteLine("             Closing Program...          ");
Console.WriteLine("=========================================");

for (int i = 0; i < 40; i++) {
    Console.Write(".");
    Thread.Sleep(25);
}
Console.WriteLine("\n\n" + "Thanks for shopping with us!" + "\n\n\n");

// DBRepository.SendCommand("SELECT * FROM USERS");
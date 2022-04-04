namespace Models;
public class User
{

    string username = "";
    string password = "";

    public User() 
    {
        this.username = "Default";
        this.password = "Default";
    }

    public User(string u, string p)
    {
        this.username = u;
        this.password = p;
    }

    private void setPassword(string s) 
    {
        this.password = s;
    }

    private void setUsername(string s) 
    {
        this.username = s;
    }

    public string getUsername() 
    {
        return this.username;
    }

    public User LoginMenu()
    {

        bool hasAccount = false;
        char[] responseToChar = {'X'};

        while (!hasAccount) 
        {
            Console.WriteLine("========================================");
            Console.WriteLine("|        CAR DEALERSHIP LOGIN          |");
            Console.WriteLine("========================================");
            Console.WriteLine("Do you already have an account?  [Y]/[N] ");

            // Trim whitespace, send to uppercase, and if null make the value X.
            try 
            {
                string response = Console.ReadLine() ?? "X";
                response = response.Trim().ToUpper();
                char[] convertedToChar = response.ToCharArray();
                responseToChar[0] = convertedToChar[0];
            }
            catch (Exception e)
            {
                // Write to log with error
                Console.WriteLine(e.ToString());
            }

            char firstLetter = responseToChar[0];
            
            switch (firstLetter)
            {
                //If the user has an account then we set hasAccount to true.
                case 'Y':
                    return loginAccount();

                //If the user doesn't have an account then we make a new account and then set hasAccount to true.
                case 'N':
                    return createAccount();

                default:
                    Console.WriteLine("\n\n\n\n");
                    break;
            }

        }

        return new User();

    }


    private User createAccount() {

        Console.WriteLine("\n\n\n");

        for (int i = 0; i < 40; i++) {
            Console.Write("=");
            Thread.Sleep(5);

            if (i == 39) {
                Console.Write("\n");
            }
        }

        Console.WriteLine("|    Great! Let's set up an account!   |");

        for (int i = 0; i < 40; i++) {
            Console.Write("=");
            Thread.Sleep(5);

            if (i == 39) {
                Console.Write("\n");
            }
        }

        /**
        *
        * Username Setup for Account Creation.
        *
        */
        Username:

        Console.WriteLine("\n\n\n");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("              New Username:             ");
        Console.WriteLine("----------------------------------------");

        string newUsername = Console.ReadLine() ?? "X";

        // Validate username is not blank, null, or otherwise invalid.
        if (newUsername == "" || newUsername == "X") {
            Console.WriteLine("Invalid username, please try again.." + "\n\n\n");
            goto Username;
        }

        if (newUsername.Length < 3 || newUsername.Length > 12) {
            Console.WriteLine("Username must be at least 3 characters and no more than 12.");
            goto Username;
        }

        setUsername(newUsername);

        /**
        *
        * Password Setup for Account Creation.
        *
        */
        Password:

        Console.WriteLine("\n\n");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("              New Password:             ");
        Console.WriteLine("----------------------------------------");
        string newPassword = Console.ReadLine() ?? "X";

        // Validate password is not blank, null, or otherwise invalid.s
        if (newPassword == "" || newPassword == "X") {
            Console.WriteLine("Invalid username, please try again.." + "\n\n\n");
            goto Password;
        }

        if (newPassword.Length < 3 || newPassword.Length > 12) {
            Console.WriteLine("Password must be at least 3 characters and no more than 12.");
            goto Password;
        }

        setPassword(newPassword);

        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        return new User(newUsername, newPassword);
    }

    private User loginAccount()
    {

        Console.WriteLine("\n\n\n");

        for (int i = 0; i < 40; i++) {
            Console.Write("=");
            Thread.Sleep(5);

            if (i == 39) {
                Console.Write("\n");
            }
        }

        Console.WriteLine("|         Great! Let's log in!         |");

        for (int i = 0; i < 40; i++) {
            Console.Write("=");
            Thread.Sleep(5);

            if (i == 39) {
                Console.Write("\n");
            }
        }

        /**
        *
        * Username Setup for Account Creation.
        *
        */
        Username:

        Console.WriteLine("\n\n\n");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("                Username:               ");
        Console.WriteLine("----------------------------------------");

        string newUsername = Console.ReadLine() ?? "X";

        // Validate username is not blank, null, or otherwise invalid.
        if (newUsername == "" || newUsername == "X" || newUsername.Length < 3 || newUsername.Length > 12) {
            Console.WriteLine("Invalid username, please try again.." + "\n\n\n");
            goto Username;
        }

        setUsername(newUsername);

        /**
        *
        * Password Setup for Account Creation.
        *
        */
        Password:

        Console.WriteLine("\n\n");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("                Password:               ");
        Console.WriteLine("----------------------------------------");

        string newPassword = Console.ReadLine() ?? "X";

        // Validate password is not blank, null, or otherwise invalid.s
        if (newPassword == "" || newPassword == "X" || newPassword.Length < 3 || newPassword.Length > 12) {
            Console.WriteLine("Invalid username, please try again.." + "\n\n\n");
            goto Password;
        }

        setPassword(newPassword);

        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        return new User(newUsername, newPassword);

    }

}

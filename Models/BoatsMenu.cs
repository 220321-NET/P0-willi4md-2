namespace Models;

    public class BoatsMenu
    {

        bool isOpen = false;

        public BoatsMenu(bool b)
        {
            this.isOpen = b;
        }

        public void OpenBoatsMenu() 
        {
            BoatsMenu:
            char[] responseToChar = {'X'};

            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================================");
            Console.WriteLine("|              Browse Boats            |");
            Console.WriteLine("========================================");
            Console.WriteLine("|        [1] Boat 1                    |");
            Console.WriteLine("|        [2] Boat 2                    |");
            Console.WriteLine("|        [3] Boat 3                    |");
            Console.WriteLine("|        [4] Boat 4                    |");
            Console.WriteLine("|        [5] Boat 5                    |");
            Console.WriteLine("==========================================================");
            Console.WriteLine("To view more details about a boat, enter its number below.");
            Console.WriteLine("        Or enter 'X' to return to the options menu.       ");
            Console.WriteLine("==========================================================");

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
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                   Logger.Log(e.ToString(), w);
                }
                goto BoatsMenu;
            }

            char firstLetter = responseToChar[0];
            
            switch (firstLetter)
            {
                case '1':
                    FirstOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Boat                           ");
                    Console.WriteLine("                    Model: 1                             ");
                    Console.WriteLine("                    Price: $10                           ");
                    Console.WriteLine("                    Inventory: 3                         ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("            To buy this boat enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the boats menu.         ");
                    Console.WriteLine("==========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("              Successfully purchased Boat 1!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BoatsMenu;
                        } else {
                            goto FirstOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        Console.WriteLine(e.ToString());
                        goto FirstOption;
                    }             
                    goto BoatsMenu;

                case '2':
                    SecondOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Boat                           ");
                    Console.WriteLine("                    Model: 2                             ");
                    Console.WriteLine("                    Price: $12                           ");
                    Console.WriteLine("                    Inventory: 4                         ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("            To buy this boat enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the boats menu.         ");
                    Console.WriteLine("==========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("              Successfully purchased Boat 2!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BoatsMenu;
                        } else {
                            goto SecondOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        Console.WriteLine(e.ToString());
                        goto SecondOption;
                    }             
                    goto BoatsMenu;

                case '3':
                    ThirdOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Boat                           ");
                    Console.WriteLine("                    Model: 3                             ");
                    Console.WriteLine("                    Price: $11                           ");
                    Console.WriteLine("                    Inventory: 2                         ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("            To buy this boat enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the boats menu.         ");
                    Console.WriteLine("==========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("              Successfully purchased Boat 3!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BoatsMenu;
                        } else {
                            goto ThirdOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        Console.WriteLine(e.ToString());
                        goto ThirdOption;
                    }             
                    goto BoatsMenu;

                case '4':
                    FourthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Boat                           ");
                    Console.WriteLine("                    Model: 4                             ");
                    Console.WriteLine("                    Price: $15                           ");
                    Console.WriteLine("                    Inventory: 1                         ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("            To buy this boat enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the boats menu.         ");
                    Console.WriteLine("==========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("              Successfully purchased Boat 4!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BoatsMenu;
                        } else {
                            goto FourthOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        Console.WriteLine(e.ToString());
                        goto FourthOption;
                    }             
                    goto BoatsMenu;

                case '5':
                    FifthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Boat                           ");
                    Console.WriteLine("                    Model: 5                             ");
                    Console.WriteLine("                    Price: $18                           ");
                    Console.WriteLine("                    Inventory: 99                        ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("            To buy this boat enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the boats menu.         ");
                    Console.WriteLine("==========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("              Successfully purchased Boat 5!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BoatsMenu;
                        } else {
                            goto FifthOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        Console.WriteLine(e.ToString());
                        goto FifthOption;
                    }             
                    goto BoatsMenu;
                    
                case 'X':
                    break;
            }
        }
        
    }

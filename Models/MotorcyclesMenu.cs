namespace Models;

    public class MotorcyclesMenu
    {

        bool isOpen = false;

        public MotorcyclesMenu(bool b)
        {
            this.isOpen = b;
        }

        public void OpenMotorcyclesMenu() 
        {
            BikeMenu:
            char[] responseToChar = {'X'};

            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================================");
            Console.WriteLine("|          Browse Motorcycles          |");
            Console.WriteLine("========================================");
            Console.WriteLine("|        [1] KTM 390 ADV               |");
            Console.WriteLine("|        [2] Husqvarna Vitpilen 701    |");
            Console.WriteLine("|        [3] Yamaha Tenere 700         |");
            Console.WriteLine("|        [4] BMW F900 XR               |");
            Console.WriteLine("|        [5] Indian FTR2100            |");
            Console.WriteLine("==========================================================");
            Console.WriteLine("To view more details about a bike, enter its number below.");
            Console.WriteLine("         Or enter 'X' to return to the options menu.      ");
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
                Console.WriteLine(e.ToString());
                goto BikeMenu;
            }

            char firstLetter = responseToChar[0];
            
            switch (firstLetter)
            {
                case '1':
                    FirstOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: KTM                            ");
                    Console.WriteLine("                    Model: 390 ADV                       ");
                    Console.WriteLine("                    Price: $8,599                        ");
                    Console.WriteLine("                    Inventory: 5                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this bike enter 'B' below.            ");
                    Console.WriteLine("        Or enter 'X' to return to the bike menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("         Successfully purchased KTM 390 ADV!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BikeMenu;
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
                    goto BikeMenu;

                case '2':
                    SecondOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Husqvarna                      ");
                    Console.WriteLine("                    Model: Vitpilen 701                  ");
                    Console.WriteLine("                    Price: $9,799                        ");
                    Console.WriteLine("                    Inventory: 4                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this bike enter 'B' below.            ");
                    Console.WriteLine("        Or enter 'X' to return to the bike menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("         Successfully purchased Husqvarna Vitpilen 701!     ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BikeMenu;
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
                    goto BikeMenu;

                case '3':
                    ThirdOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Yamaha                         ");
                    Console.WriteLine("                    Model: Tenere 700                    ");
                    Console.WriteLine("                    Price: $9,999                        ");
                    Console.WriteLine("                    Inventory: 1                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this bike enter 'B' below.            ");
                    Console.WriteLine("        Or enter 'X' to return to the bike menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("         Successfully purchased Yamaha Tenere 700!          ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BikeMenu;
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
                    goto BikeMenu;

                case '4':
                    FourthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: BMW                            ");
                    Console.WriteLine("                    Model: F 900 XR                      ");
                    Console.WriteLine("                    Price: $12,999                       ");
                    Console.WriteLine("                    Inventory: 11                        ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this bike enter 'B' below.            ");
                    Console.WriteLine("        Or enter 'X' to return to the bike menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("      Successfully purchased BMW F900 XR!                   ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BikeMenu;
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
                    goto BikeMenu;

                case '5':
                    FifthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Indian                         ");
                    Console.WriteLine("                    Model: FTR1200                       ");
                    Console.WriteLine("                    Price: $11,599                       ");
                    Console.WriteLine("                    Inventory: 8                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this bike enter 'B' below.            ");
                    Console.WriteLine("        Or enter 'X' to return to the bike menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("             Successfully purchased Indian FTR2100!         ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                        } else if (responseArray[0] == 'X') {
                            goto BikeMenu;
                        } else {
                            goto FifthOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                        {
                            Logger.Log(e.ToString(), w);
                        }
                        goto FifthOption;
                    }             
                    goto BikeMenu;
                    
                case 'X':
                    break;
            }
        }
        
    }

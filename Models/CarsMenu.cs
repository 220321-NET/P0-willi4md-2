namespace Models;

    public class CarsMenu
    {

        bool isOpen = false;

        public CarsMenu(bool b)
        {
            this.isOpen = b;
        }

        public void OpenCarsMenu(User u) 
        {
            CarsMenu:
            char[] responseToChar = {'X'};

            Console.WriteLine("\n\n\n");
            Console.WriteLine("========================================");
            Console.WriteLine("|              Browse Cars             |");
            Console.WriteLine("========================================");
            Console.WriteLine("|        [1] Nissan ALTRA EV           |");
            Console.WriteLine("|        [2] Honda CRF230M             |");
            Console.WriteLine("|        [3] Polaris 600 Switchback    |");
            Console.WriteLine("|        [4] Mercedes-Benz SLK55 AMG   |");
            Console.WriteLine("|        [5] Audi S4                   |");
            Console.WriteLine("=========================================================");
            Console.WriteLine("To view more details about a car, enter its number below.");
            Console.WriteLine("        Or enter 'X' to return to the options menu.      ");
            Console.WriteLine("=========================================================");

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
                goto CarsMenu;
            }

            char firstLetter = responseToChar[0];
            
            switch (firstLetter)
            {
                case '1':
                    FirstOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Nissan                         ");
                    Console.WriteLine("                    Model: ALTRA EV                      ");
                    Console.WriteLine("                    Price: $15,599                       ");
                    Console.WriteLine($"                    Inventory: {DBRepository.GetCarStock(int.Parse(firstLetter.ToString()))}                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");
                    Car someCar = new Car("Nissan", "ALTRA EV", 15599);
                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("         Successfully purchased Nissan ALTRA EV!            ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                            DBRepository.SendCommand("UPDATE Cars SET Stock = Stock - 1");
                            Random rnd = new Random();
                            DBRepository.InsertOrders(rnd.Next(1, 50000), u.getUsername(), someCar.toString(someCar));
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
                        } else {
                            goto FirstOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                        {
                            Logger.Log(e.ToString(), w);
                        }
                        goto FirstOption;
                    }             
                    goto CarsMenu;

                case '2':
                    SecondOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Honda                          ");
                    Console.WriteLine("                    Model: CRF230M                       ");
                    Console.WriteLine("                    Price: $24,799                       ");
                    Console.WriteLine($"                    Inventory: {DBRepository.GetCarStock(int.Parse(firstLetter.ToString()))}                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");
                    Car someCar2 = new Car("Honda", "CRF230M", 24799);
                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("         Successfully purchased Honda CRF230M!              ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                            DBRepository.SendCommand("UPDATE Cars SET Stock = Stock - 1");
                            Random rnd = new Random();
                            DBRepository.InsertOrders(rnd.Next(1, 50000), u.getUsername(), someCar2.toString(someCar2));
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
                        } else {
                            goto SecondOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                        {
                            Logger.Log(e.ToString(), w);
                        }
                        goto SecondOption;
                    }             
                    goto CarsMenu;

                case '3':
                    ThirdOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Polaris                        ");
                    Console.WriteLine("                    Model: 600 Switchback                ");
                    Console.WriteLine("                    Price: $11,299                       ");
                    Console.WriteLine($"                    Inventory: {DBRepository.GetCarStock(int.Parse(firstLetter.ToString()))}                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");
                    Car someCar3 = new Car("Polaris", "600 Switchback", 11299);
                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("     Successfully purchased Polaris 600 Switchback!         ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                            DBRepository.SendCommand("UPDATE Cars SET Stock = Stock - 1");
                            Random rnd = new Random();
                            DBRepository.InsertOrders(rnd.Next(1, 50000), u.getUsername(), someCar3.toString(someCar3));
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
                        } else {
                            goto ThirdOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                        {
                            Logger.Log(e.ToString(), w);
                        }
                        goto ThirdOption;
                    }             
                    goto CarsMenu;

                case '4':
                    FourthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Mercedes-Benz                  ");
                    Console.WriteLine("                    Model: SLK55 AMG                     ");
                    Console.WriteLine("                    Price: $31,999                       ");
                    Console.WriteLine($"                    Inventory: {DBRepository.GetCarStock(int.Parse(firstLetter.ToString()))}                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");
                    Car someCar4 = new Car("Mercedes-Benz", "SLK55 AMG", 31999);
                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("      Successfully purchased Mercedes Benz SLK55 AMG!       ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                            DBRepository.SendCommand("UPDATE Cars SET Stock = Stock - 1");
                            Random rnd = new Random();
                            DBRepository.InsertOrders(rnd.Next(1, 50000), u.getUsername(), someCar4.toString(someCar4));
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
                        } else {
                            goto FourthOption;
                        }
                    }
                    catch (Exception e)
                    {
                        // Write to log with error
                        using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                        {
                            Logger.Log(e.ToString(), w);
                        }
                        goto FourthOption;
                    }             
                    goto CarsMenu;

                case '5':
                    FifthOption:
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("                    Make: Audi                           ");
                    Console.WriteLine("                    Model: S4                            ");
                    Console.WriteLine("                    Price: $26,599                       ");
                    Console.WriteLine($"                    Inventory: {DBRepository.GetCarStock(int.Parse(firstLetter.ToString()))}                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");
                    Car someCar5 = new Car("Audi", "S4", 26599);
                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("------------------------------------------------------------");
                            Console.WriteLine("             Successfully purchased Audi S4!                ");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                            Console.WriteLine("------------------------------------------------------------");
                            DBRepository.SendCommand("UPDATE Cars SET Stock = Stock - 1");
                            Random rnd = new Random();
                            DBRepository.InsertOrders(rnd.Next(1, 50000), u.getUsername(), someCar5.toString(someCar5));
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
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
                    goto CarsMenu;
                    
                case 'X':
                    break;

                default:
                    goto CarsMenu;
            }
        }
        
    }

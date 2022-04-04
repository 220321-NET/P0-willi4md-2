namespace Models;

    public class CarsMenu
    {

        bool isOpen = false;

        public CarsMenu(bool b)
        {
            this.isOpen = b;
        }

        public void OpenCarsMenu() 
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
                Console.WriteLine(e.ToString());
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
                    Console.WriteLine("                    Inventory: 3                         ");
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("            To buy this car enter 'B' below.             ");
                    Console.WriteLine("        Or enter 'X' to return to the cars menu.         ");
                    Console.WriteLine("=========================================================");

                    try 
                    {
                        string response = Console.ReadLine() ?? "X";
                        response = response.ToUpper().Trim();
                        char[] responseArray = response.ToCharArray();
                        if (responseArray[0] == 'B') {
                            Console.WriteLine("\n" + "Successfully purchased Nissan ALTRA EV!");
                            Console.WriteLine("To view this order, return to the options menu and press '0'");
                        } else if (responseArray[0] == 'X') {
                            goto CarsMenu;
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
                    goto CarsMenu;

                case '2':
                    goto CarsMenu;

                case '3':
                    goto CarsMenu;

                case '4':
                    goto CarsMenu;

                case '5':
                    goto CarsMenu;
                    
                case 'X':
                    break;
            }
        }
        
    }

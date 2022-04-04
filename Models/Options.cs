namespace Models;
using System;
using System.IO;

public class Options
{
        bool isOpen;

        public Options() 
        {
            this.isOpen = true;
        }

        public Options(bool x)
        {
            this.isOpen = x;
        }

        private void SetOpen(bool x) 
        {
            this.isOpen = x;
        }

        public void OpenOptionsMenu() 
        {
            OpenMenu:
            char[] responseToChar = {'X'};

            Console.WriteLine("========================================");
            Console.WriteLine("|             Options Menu             |");
            Console.WriteLine("========================================");
            Console.WriteLine("|                                      |");
            Console.WriteLine("|            [0] Order History         |");
            Console.WriteLine("|            [1] Shop Cars             |");
            Console.WriteLine("|            [2] Shop Motorcycles      |");
            Console.WriteLine("|            [3] Shop Boats            |");
            Console.WriteLine("|            [4] Shop Planes           |");
            Console.WriteLine("|            [X] Exit                  |");
            Console.WriteLine("|                                      |");
            Console.WriteLine("========================================");

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
                goto OpenMenu;
            }

            char firstLetter = responseToChar[0];
            
            switch (firstLetter)
            {
                case '0':
                    goto OpenMenu;

                case '1':
                    CarsMenu carsmenu = new CarsMenu(true);
                    carsmenu.OpenCarsMenu();
                    goto OpenMenu;

                case '2':
                    MotorcyclesMenu motorcyclesmenu = new MotorcyclesMenu(true);
                    motorcyclesmenu.OpenMotorcyclesMenu();
                    goto OpenMenu;

                case '3':
                    BoatsMenu boatsmenu = new BoatsMenu(true);
                    boatsmenu.OpenBoatsMenu();
                    goto OpenMenu;

                case '4':
                    PlanesMenu planesMenu = new PlanesMenu(true);
                    planesMenu.OpenPlanesMenu();
                    goto OpenMenu;

                case 'X':
                    break;

                default:
                    goto OpenMenu;
            }

        }
}

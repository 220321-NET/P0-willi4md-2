namespace Models;

    public class OrderHistoryMenu
    {
        
        public void getOrderHistory(User u)
        {
            Order[] orders = DBRepository.getOrderHistory(u);
            try
            {
                for (int i = 0; i < orders.Count(); i++)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Order #: \n" + orders[i].getOrderNumber());
                    Console.WriteLine("Order Description: \n" + orders[i].getOrderDesc());
                    Console.WriteLine("------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                // Write to log with error
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                    Logger.Log(e.ToString(), w);
                }
            }
        }

    }

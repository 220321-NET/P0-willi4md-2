namespace Models;
using System.Data.SqlClient;
using Models;

    public static class DBRepository
    {
        public static void buildConnString() {

            try
            {

                SqlConnection? connection = GetConnection();

                using (connection)
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");
                    
                    connection.Open();       

                    String sql = "SELECT * FROM USERS";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }                    
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }


        }

        public static SqlConnection GetConnection()
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "revature-p0.database.windows.net"; 
            builder.UserID = "willi4md";            
            builder.Password = "pass.123";     
            builder.InitialCatalog = "RevatureP0";
            return new SqlConnection(builder.ConnectionString);
        }

        public static void SendCommand(string input)
        {

            try
            {

                SqlConnection? connection = GetConnection();

                using (connection)
                {
                    
                    connection.Open();       

                    String sql = input;

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                // Log any SQL Exceptions to the logs file indicated below.
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                    Logger.Log(e.ToString(), w);
                }
            }
        }

        public static bool ValidateUsernameInput(string username)
        {
            bool matchFound = false;

            try
            {

                SqlConnection? connection = GetConnection();

                using (connection)
                {   
                    connection.Open();       

                    String sql = "SELECT * FROM Users";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                                if (reader.GetString(0) == username)
                                {
                                    matchFound = true;
                                }
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                // Log any SQL Exceptions to the logs file indicated below.
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                    Logger.Log(e.ToString(), w);
                }
            }
            return matchFound;
        }

        public static int GetCarStock(int x)
        {

            try
            {

                SqlConnection? connection = GetConnection();

                using (connection)
                {   
                    connection.Open();       

                    String sql = "SELECT * FROM Cars";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int carID = reader.GetInt32(0);
                                int stock =  reader.GetInt32(3);

                                if (carID == x)
                                {
                                    return stock;
                                }
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                // Log any SQL Exceptions to the logs file indicated below.
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                    Logger.Log(e.ToString(), w);
                }
            }
            return 0;
        }



        public static void InsertData(string col1, string col2)
        {
            using(SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Users (username, pword) VALUES (@id, @pword)";
                connection.Open();

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", col1);
                    command.Parameters.AddWithValue("@pword", col2);

                    int result = command.ExecuteNonQuery();
                }

            }
        }

        public static void InsertOrders(int col1, string col2, string col3)
        {
            using(SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Orders (OrderNum, CurUser, OrderDesc) VALUES (@OrderNum, @CurUser, @OrderDesc)";
                connection.Open();

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OrderNum", col1);
                    command.Parameters.AddWithValue("@CurUser", col2);
                    command.Parameters.AddWithValue("@OrderDesc", col3);

                    int result = command.ExecuteNonQuery();
                }

            }
        }

        public static Order[] getOrderHistory(User u)
        {

            Order[] orders = new Order[100];
            int counter = 0;

            try
            {

                SqlConnection? connection = GetConnection();

                using (connection)
                {
                    
                    connection.Open();       

                    String sql = "SELECT * FROM Orders";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1) == u.getUsername() || u.getUsername() == "admin") {
                                    Order thisOrder = new Order(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                                    orders[counter] = thisOrder;
                                    counter++;
                                }
                            }
                        }
                    }                    
                }
            }
            catch (SqlException e)
            {
                // Log any SQL Exceptions to the logs file indicated below.
                using (StreamWriter w = File.AppendText("C:/Users/Matthew/Desktop/P0-TWO/DL/logs.txt"))
                {
                    Logger.Log(e.ToString(), w);
                }
            }
            return orders;
        }

        


        
    }

namespace UI;
using System.Data.SqlClient;

    public static class sqlTest
    {
        public static void buildConnString() {

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "revature-p0.database.windows.net"; 
                builder.UserID = "willi4md";            
                builder.Password = "pass.123";     
                builder.InitialCatalog = "RevatureP0";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
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
        
    }

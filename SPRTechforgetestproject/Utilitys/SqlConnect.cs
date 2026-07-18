using System;
using MySql.Data.MySqlClient;

namespace SPRTechforgetestproject.Utilitys
{
    public class SqlConnect
    {
       
        [Test]
        public  void ConnectToDatabase()
        {
            string connString = "Server=localhost;Port=3306;Database=CompanyDB;Uid=root;Pwd=Gudari@9640;";

           

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connected to MySQL successfully!\n");

                    string query = "SELECT * FROM Employees";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader["EmployeeName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

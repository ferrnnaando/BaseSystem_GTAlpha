/*using MySql.Data.MySqlClient;
using System;

namespace BaseSystem.SQL
{
    public class MySQL
    {
        public static MySqlConnection connection; 
        internal static bool IsConnectionSetup = false;
        public String Address { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Schema { get; set; }

        internal MySQL()
        {
            this.Address = "localhost";
            this.Username = "server";
            this.Password = "12fekrew";
            this.Schema = "gtalpha_db";
        }

        public static void LoadMySQLConnection()
        {
            MySQL sql = new MySQL();
            String connMaker = $"SERVER={sql.Address};PASSWORD={sql.Password};UID={sql.Username};DATABASE={sql.Schema}";
            connection = new MySqlConnection(connMaker);

            try
            {
                connection.Open(); //what is open async
                Console.WriteLine($"[+] MySQL connection could be initialized and established on {sql.Address} address, {sql.Schema} database with the {sql.Username} username and the password ******.");
                IsConnectionSetup = true;
            } catch (Exception ex)
            {
                Console.WriteLine($"[-] MySQL connection couldn't be established by the error: {ex}.");
            }
        }
    }
}
*/
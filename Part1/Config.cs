using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public static class Config
    {
        //Fields for configuration settings
        public static string ConnectionString { get; set; }
        //Update Config Informaiton

        public static void UpdateConnectionString(string server, string database, string userName, string password)
        {
            string driver ="Driver = {SQL Server Native 11.0};";
            string serv = $"Server= {server};";
            string db = $"Database={database};";
            string userID = $"Uid={userName};";
            string pass = $"Pwd={password};";

            ConnectionString = $"{driver}{serv}{db}{userID}{pass}";
        }




    }
}

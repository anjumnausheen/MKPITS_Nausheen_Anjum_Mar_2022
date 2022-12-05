using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection");

           

            string connstring = "Data Source =LAPTOP-CEIB5MST\\SQLEXPRESS;Initial catalog=joins;Integrated security=True ";

            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                Console.WriteLine("Opening Connection:");
                conn.Open();
                Console.WriteLine("Connection Successful");

            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
            }
            Console.Read();
        }
    }
}

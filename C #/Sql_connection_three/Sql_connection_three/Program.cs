using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection");

            string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial catalog= Joins;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                Console.WriteLine("Opening Connection");
                conn.Open();

                SqlCommand cmd=new SqlCommand("Insert into suppliers values ('12','105','s009')",conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Connection Successful");
            }
            catch(Exception e) 
            {
                Console.WriteLine("Error :"+e.Message);
            }
            Console.Read();


        }
    }
}

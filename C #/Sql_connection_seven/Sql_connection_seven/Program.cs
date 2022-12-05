using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection");
            string connstring = "Data source= LAPTOP-CEIB5MST\\SQLEXPRESS;Initial catalog=Joins;Integrated security=True";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                Console.WriteLine("Opening connection");
                conn.Open();
                // SqlCommand cmd=new SqlCommand("delete from suppliers where city='Hyederabad'",conn);
                SqlCommand cmd = new SqlCommand("update suppliers  set name='Ravi',city='Nag' where sid='s003'", conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("connection successful");

                
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
            }
            Console.ReadLine();

        }
    }
}

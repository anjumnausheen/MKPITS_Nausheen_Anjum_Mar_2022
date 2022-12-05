using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_six
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstring = "Data source= LAPTOP-CEIB5MST\\SQLEXPRESS;Initial catalog=Joins;Integrated security=True";
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update suppliers SET name=Rahul where sid=S007", conn);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}

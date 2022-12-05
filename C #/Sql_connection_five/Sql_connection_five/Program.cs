using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";
           
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from suppliers",conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Console.WriteLine("sid = "+reader.GetString(0)+" sname = "+reader.GetString(1)+" scity= "+reader.GetString(2));
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error :"+e.Message);
            }
            Console.Read();

            
        }
    }
}

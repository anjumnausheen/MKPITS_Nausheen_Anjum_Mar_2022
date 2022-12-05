using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection");
            string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                conn.Open();
                string sup_id, sup_name, scity;
                //Getting Input from the user
                Console.WriteLine("Enter supplier id");
                sup_id=Console.ReadLine().Trim();
                Console.WriteLine("Enter supplier name");
                sup_name=Console.ReadLine().Trim();
                Console.WriteLine("Enter supplier city");
                scity=Console.ReadLine().Trim();

                SqlCommand cmd= new SqlCommand("Insert into suppliers values('"+sup_id+"','"+sup_name+"','"+scity+"')",conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
            }
            Console.Read();
        }
    }
}

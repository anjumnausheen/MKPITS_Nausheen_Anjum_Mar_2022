using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection:");

            string connstring = "Data Source = LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=Joins;Integrated security=True";

            SqlConnection conn=new SqlConnection(connstring);

            try
            {
                //open connection
                conn.Open();
                    //insert into database
                     SqlCommand cmd = new SqlCommand
                    //("Insert into suppliers values('7','Ravi','Hyederabad')",conn);
                    ("Insert into suppliers values ('8','Mohan','Pune')", conn);
                    cmd.ExecuteNonQuery();
                Console.WriteLine("Connection Successful");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message);
            }
            Console.Read();
        }
    }
}

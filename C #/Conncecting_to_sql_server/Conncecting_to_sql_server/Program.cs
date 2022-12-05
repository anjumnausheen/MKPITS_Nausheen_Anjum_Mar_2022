using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Conncecting_to_sql_server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection");
            /*string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                Console.WriteLine("Opening Connection");
                //open connection
                conn.Open();
                // INSERT INTO DATABASE
                *//*SqlCommand cmd = new SqlCommand("INSERT INTO suppliers VALUES('S006', 'Mickey', 'Pune')", conn);
                cmd.ExecuteNonQuery();*//*

                SqlCommand cmd = new SqlCommand("INSERT INTO SUPPLIERS VALUES('11','107','soo7')", conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Connection successful");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error:"+e.Message);
            }*/



            /* string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";

             SqlConnection conn = new SqlConnection(connstring);
             try
             {
                 conn.Open();
                 string sup_id, sup_name, scity;
                 *//*  sup_id = "S007";
                   sup_name = "John";
                   scity = "Rohtang";*/
            /* SqlCommand cmd = new SqlCommand("INSERT INTO suppliers VALUES('"+sup_id+"', '"+sup_name+"', '"+scity+"')", conn);
             cmd.ExecuteNonQuery();*//*


            // GETTING INPUT NFROM THE USER
            Console.WriteLine("Enter supplier name");
            sup_name = Console.ReadLine();
            Console.WriteLine("Enter sup id");
            sup_id = Console.ReadLine().Trim();
            Console.WriteLine("Enter supplier city");
            scity = Console.ReadLine().Trim();
            SqlCommand cmd = new SqlCommand("INSERT INTO suppliers VALUES('" + sup_id + "', '" + sup_name + "', '" + scity + "')", conn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error:" + e.Message);
        }
*/

            string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connstring);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM SUPPLIERS", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Sid = " + reader.GetString(0) + " Sname = " + reader.GetString(1) + " S City = " + reader.GetString(2));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }


            Console.Read();
        }
    }
}

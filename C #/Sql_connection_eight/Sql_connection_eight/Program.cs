using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql_connection_eight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting connection");

            string connstring = "Data Source=LAPTOP-CEIB5MST\\SQLEXPRESS;Initial Catalog=joins;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd;
            try
            {
                conn.Open();

                string name, sid, city;

                // Getting Input from the user
                Console.WriteLine("Enter Your choice. \n1.Select\n2.Insert\n3.Update\n4.Delete");

                int ch;
                ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        cmd = new SqlCommand("Select * from suppliers ", conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("sid= " + reader.GetString(0) + "name=" + reader.GetString(1) + "city=" + reader.GetString(2));
                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter supplier name");
                        name = Console.ReadLine().Trim();
                        Console.WriteLine("Enter supplier sid");
                        sid = Console.ReadLine().Trim();
                        Console.WriteLine("Enter supplier city");
                        city = Console.ReadLine().Trim();
                        

                        cmd = new SqlCommand("Insert into suppliers values('" + sid + "','" + name + "','" + city + "')", conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Inserted Record successfully");
                        break;

                    case 3:
                        Console.WriteLine("Update");
                        Console.WriteLine("Enter supplier id to update");
                        sid = Console.ReadLine().Trim();
                        Console.WriteLine("Enter supplier name");
                        name = Console.ReadLine().Trim();
                        Console.WriteLine("Enter supplier city");
                        city = Console.ReadLine().Trim();
                        cmd = new SqlCommand("update suppliers set name='" + name + "', city= '" + city + "' where sid = '"+sid+"' ", conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("UPDATED RECORD SUCCESSFULLY.....");
                        break;


                    case 4:
                        // enter supplier id message type here
                        Console.WriteLine("Enter sid to delete");
                        sid = Console.ReadLine().Trim();

                        cmd = new SqlCommand("Delete from suppliers where sid='" + sid + "'", conn);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Deleted Record successfully");
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

            Console.ReadLine();
        
        }
    }
}

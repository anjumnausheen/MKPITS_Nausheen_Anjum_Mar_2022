using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_five
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                checkAge(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception occured");
            }
        }


        static void checkAge(int age)
        {
            if(age < 18)
            {
                throw new ArithmeticException("Access Denied - You must be atleast 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted- Your are old enough");
            }
            
        }
       // Console.ReadLine();
        }
    }



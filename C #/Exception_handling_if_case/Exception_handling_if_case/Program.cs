using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_if_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checkAge(20);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception Occured");
            }

        }
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be atleast 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough");
            }
        }
    }
}

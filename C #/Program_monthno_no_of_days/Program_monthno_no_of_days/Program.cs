using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_monthno_no_of_days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter any number:");
            x = Convert.ToInt32(Console.ReadLine());

            if(x == 1) 
            {
                Console.WriteLine("January 31 days");
            }
            else if(x == 2) 
            {
                Console.WriteLine("February 28 days");
            }
            else if(x == 3)
            {
                Console.WriteLine("March 31 days");
            }
            else if(x == 4)
            {
                Console.WriteLine("April 30 days");
            }
            else if(x == 5)
            {
                Console.WriteLine("May 31 days");
            }
            else if(x == 6)
            {
                Console.WriteLine("June 30 days");
            }
            else if(x == 7)
            {
                Console.WriteLine("July 31 days");
            }
            else if(x == 8)
            {
                Console.WriteLine("August 31 days");
            }
            else if(x == 9)
            {
                Console.WriteLine("September 30 days ");
            }
            else if( x == 10)
            {
                Console.WriteLine("October 31 days");
            }
            else if(x == 11)
            {
                Console.WriteLine("November 30 days");
            }
            else if(x == 12)
            {
                Console.WriteLine("December 31 days");
            }
            else 
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}

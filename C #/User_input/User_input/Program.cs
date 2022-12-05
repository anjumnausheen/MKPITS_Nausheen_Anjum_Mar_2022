using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type your user name and press enter
            Console.WriteLine("Enter Username:");
           
            
            //Create a string variable and get user input from the keyboard and store it in the variable
            string username=Console.ReadLine();
            
            Console.WriteLine("Username is ="+username);
            
            Console.ReadLine();
        }
    }
}

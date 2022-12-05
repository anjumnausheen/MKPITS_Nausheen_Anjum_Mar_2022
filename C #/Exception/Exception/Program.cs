using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Wrong code
            //  int x = 3, y = 0, z;
            //  z = x / y;
            //  Console.WriteLine(z);
            // Console.WriteLine("After Division");

            int x = 3, y = 0, z;
            try
            {
                z = x / y;
                Console.WriteLine(z);
            }catch(Exception ex)
            {
                Console.WriteLine("Divide by zero exception:");
            }
            Console.WriteLine("After Division");
            
            
            
            
            
            
            Console.ReadLine();
        }
    }
}

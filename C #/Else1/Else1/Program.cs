using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            if(time<18)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
                Console.ReadLine();
            }
        }
    }
}

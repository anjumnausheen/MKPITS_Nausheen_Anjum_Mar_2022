using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_each_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

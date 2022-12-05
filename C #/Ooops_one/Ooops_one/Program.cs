using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.show();

            Console.ReadLine();

        }
    }

    class Demo
    {
        public void show()
        {
            Console.WriteLine("This is show function");
        }
    }

    

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_class
{
    internal class External_class_one
    {
        public void add()
        {
            Console.WriteLine("Enter 2 nos:");
            int a, b, c;
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Addition= "+c);
        }
    }
}

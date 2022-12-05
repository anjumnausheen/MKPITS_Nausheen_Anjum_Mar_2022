using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod(child3: "John",child1: "Liam",child2: "Liam");
            Console.ReadLine();
        }
        static void MyMethod(string child1,string child2,string child3)
        {
            Console.WriteLine("The Youngest Child is:" + child3);
        }
    }
}

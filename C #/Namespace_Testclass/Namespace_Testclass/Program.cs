using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_space;
using second_space;


namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class efg
    {
        public void func2()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}




namespace Namespace_Testclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            abc fc=new abc();
            efg sc=new efg();

            fc.func();
            sc.func2();

            Console.ReadLine();
        }
    }
}
//Because using word is used so we can create direct object

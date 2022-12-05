using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_space
{
    class namespace_c1
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class namespace_c2
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}





namespace Namespace_example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first_space.namespace_c1 fc=new first_space.namespace_c1();

            second_space.namespace_c2 sc=new second_space.namespace_c2();

            fc.func();

            sc.func();

            Console.ReadLine();
        }
    }
}

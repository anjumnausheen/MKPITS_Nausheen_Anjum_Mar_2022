using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_abstract_class_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat mycat=new Cat();//create a cat object
            mycat.animalsound();//call the regular method;
            mycat.sleep();//call the abstract method

            Console.ReadLine();
        }

    }
    abstract class Animal
    {
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

        // YOU CANNOT DEFINE ABSTRACT METHOD/function
        abstract public void disp();
    }
    class Cat:Animal
    {
        public void animalsound()
        {
            Console.WriteLine("The cat says:Meo Meo");
        }

        // IT IS COMPULSORY TO DEFINE ABSTRACT METHOD IN CHILD CLASS WITH OVERRIDE KEYWORD
        public override void disp()
        {
            Console.WriteLine("This is disp function of abstract class");
        }
    }
}

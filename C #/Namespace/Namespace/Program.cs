using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace//wrong program
{
    class One
    {
        public void fun1()
        {
            Console.WriteLine("Function one");
        }
        public void fun2()
        {
            Console.WriteLine("Function two");
        }
    }
        class Two
        {
            public void fun3()
            {
                Console.WriteLine(" Function three ");
            }
        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            student s2 = new student();

            s1.count();
            s2.count();
            s1.count();
            s2.count();

            s1.show();
            s2.show();

            Namespace .One o=new Namespace .One();
            o.fun2();
            o.fun1();
            

           Namespace .Two t= new Namespace.Two();
            t.fun3();



            

            Console.ReadLine();
        

        
        }
    }
    class student
    {
        static void add()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("\tAddition = "+c);
        }

        int x = 1;
        int y = 2;

        public  void count()
        {
            x++;
            y++;
        }
        public void show()
        {
            Console.WriteLine(" x= " + x + " y = " + y);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// NAMESPACE IS THE COLLECTION OF CLASSES

namespace First_namespace
{
    class One
    {
        public void fun1()
        {
            Console.WriteLine("Functin one");
        }
        public void fun2()
        {
            Console.WriteLine("Function two");
        }
    }
    class Two
    {
        public void demo()
        {
            Console.WriteLine("Demo function");
        }
    }
}

namespace Static_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            Student.count();
            Student.count();
            Student.count();

            s1.show();
            s2.show();


            First_namespace.One o = new First_namespace.One();
            o.fun2();

        }
    }
    class Student
    {
        // X IS STATIC VARIABLE
        static int x =0;
        int y =0;

        // COUNT IS STATIC FUNCTION SO IT CAN ACCESS ONLY STATIC VARIABLES.
        /*
            * IT CAN ACCESS ONLY STATIC VARIABLES AND THIS FUNCTION CANNOT BE CALLED USING OBJECT
            * IT CAN BE CALLED ONLY WITH CLASS NAME
            */
        public static void count()
        {
            x++;
           /* y++;*/
        }
        public void show()
        {
            Console.WriteLine("X = " + x + " y = " + y);
        }
    }
}

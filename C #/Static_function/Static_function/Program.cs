using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1=new student();
            student s2=new student();

            student.count();
            student.count();
            student.count();

            s1.show();
            s2.show();

            Console.ReadLine();


        }
    }
    class student
    {
        // x is static variable
        static int x = 0;
        int y = 0;

        public static void count()
        {
            x++;
            //y++;
        }
        public void show()
        {
            Console.WriteLine("x = " + x +" y = " + y);
        }
    }

}

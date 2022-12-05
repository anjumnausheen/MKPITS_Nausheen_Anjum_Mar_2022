using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1=new student();
            student s2=new student();

            s1.count();
            s2.count();
            s1.count();

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

        //COUNT IS STATIC FUNCTION SO IT CAN ACCESS ONLY STATIC VARIABLES *//
        
        // IT CAN ACCESS ONLY STATIC VARIABLES AND THIS FUNCTION CAN NOT BE CALLED USING OBJECT 
        // IT CAN BE CALLED ONLY WITH CLASS NAME

        public  void count()
        {
            x++;
            y++;
        }
        public void show()
        {
            Console.WriteLine(" x = " + x + " y = " + y);
        }
    }
}

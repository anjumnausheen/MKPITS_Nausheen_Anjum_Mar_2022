using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.show();
            student.show(4, 8);
            student.show(8);


            Console.ReadLine();
        }
    }

    class Student
    {
        // polymorphism-> Function overloading
        // function overloadiing means function with same name and different parameters
        public void show()
        {
            Console.WriteLine("Show function");
        }
        public void show(int a)
        {
            Console.WriteLine("Show function a = " + a);
        }
        public void show(int a, int b)
        {
            Console.WriteLine("Show function a = " + a + " b = " + b);
        }
    }


}

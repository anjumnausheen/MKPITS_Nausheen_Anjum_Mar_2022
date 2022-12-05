using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_tice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Polymorphism
            //Function overloading means Function with same name but different parameters

            Student stu = new Student();

            stu.add(10);
            stu.add(10, 20);
            stu.add(30,30,30);

            Console.ReadLine();


        }
    }
   class Student
    {
        public void add(int a)
        {
            Console.WriteLine("Addition ="+a);
        }
        public void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(" Addition =" + c);
        }
        public void add(int a,int b,int c)
        {
            int d= a + b + c;
            Console.WriteLine("Addition = " + d);
        }
    }
    
}

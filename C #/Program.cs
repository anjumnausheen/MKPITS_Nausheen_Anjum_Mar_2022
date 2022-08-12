using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_with_Method_Overloading
{
    class Student
    {
        int rn;
        string name, course;
        int fees;

        public void getdata()
        {
            rn = 9;
            name = "neelu";
            course = "python";
            fees = 8000;
        }
        // method overloaded
        public void getdata(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
        }
        public void getdata(int rn, string name, string course)
        {
            this.rn = rn;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rn, string name, string course, int fees)
        {
            this.rn = rn;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("student roll no = " + rn);
            Console.WriteLine("student name = " + name);
            Console.WriteLine("course= " + course);
            Console.WriteLine("fees= " + fees);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getdata();
            s.display();

            Console.WriteLine("------------------------");


            Console.WriteLine("------------------------");
            Console.WriteLine("student  details");
            Student s2 = new Student();
            s2.getdata(123, "ayesha");
            s2.display();
            Console.WriteLine("------------------------");
            Console.WriteLine("Student  details");
            Student s3 = new Student();
            s3.getdata(123, "ayesha", "java");
            s3.display();
            Console.WriteLine("------------------------");
            Console.WriteLine("student  details");
            Student s4 = new Student();
            s4.getdata(123, "ayesha", "java", 10000);
            s4.display();



            Console.ReadLine();
        }
    }
}

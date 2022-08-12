using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Employee_create_constructor
{
    class Employee
    {
        int empno;
        string empname, desig;
        float sal;

        public Employee()
        {
            empno = 1;
            empname = "rumi";
            sal = 40000.25f;
            desig = "Manager";

        }
        public void display()
        {
            Console.WriteLine("emp no=" + empno);
            Console.WriteLine("emp name=" + empname);
            Console.WriteLine("designation=" + desig);
            Console.WriteLine("salary=" + sal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();
            Console.ReadLine();
        }
    }
}

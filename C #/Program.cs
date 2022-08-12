using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_26_empno_empname
{
    class Employee
    {
        public int empno;
        public String empname;
        public float salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empno = 123;
            emp.empname = "Raj";

            emp.salary = 12000.2f;

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("salary " + emp.salary);
            Console.ReadLine();
        }
    }
}

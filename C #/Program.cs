using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_28_getdata_showdata
{
    class Employee
    {
        int empno;
        String empname;
        float salary;
        
        public void getdata()
        {

            Console.WriteLine("enter employee no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToSingle(Console.ReadLine());

        }
        public void displaydata()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("salary " + salary);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.getdata();
            emp.displaydata();

            Console.ReadLine();
        }
    }
}

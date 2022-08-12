using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_with_Constructor_and_parameter
{
    class Employee
    {
        int empno;
        string empname;
        string desig;
        int salary;

        //creating a  constructor with no parameters
        public Employee()
        {
            empno = 1;
            empname = "Rani";
            desig = "teacher";
            salary = 50000;
        }


        //creating a  parameterized constructor with 4 parameters
        public Employee(int empno, string empname, string desig, int salary)
        {
            Console.WriteLine("Constructor with parameter called");
            this.empno = empno;
            this.empname = empname;
            this.desig = desig;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("emp no=" + empno);
            Console.WriteLine("emp name=" + empname);
            Console.WriteLine("emp designation=" + desig);
            Console.WriteLine("emp salary=" + salary);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(); //this will call constructor automatically
            e.display();

            Console.WriteLine("--------employee 1 details -------");
            Employee e1 = new Employee(5, "meena", "Peon", 10000);// this will call parameterized constructor
            e1.display();

            Console.WriteLine("-----------------Employee 2 details ----------");
            Console.WriteLine("enter emp no");
            int emp1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter emp name");
            String nam1 = Console.ReadLine();
            Console.WriteLine("enter emp designation");
            String desi1 = Console.ReadLine();
            Console.WriteLine("enter emp salary");
            int sal1 = Convert.ToInt32(Console.ReadLine());

            Employee e2 = new Employee(emp1, nam1, desi1, sal1);// this will call parameterized constructor
            e2.display();

            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_27_emp_values_user
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
            Console.WriteLine("enter employee no");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            emp.empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            emp.salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("salary " + emp.salary);
            Console.ReadLine();
        }
    }
}

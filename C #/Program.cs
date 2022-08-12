﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_employee_create_method
{
    public class Employee
    {
        public int empno;
        public string empnam;
        public string desig;
        public double sal;

        public void calculate_salary(int empno, string empnam, string desig, double sal)
        {
            this.empno = empno;
            this.empnam = empnam;
            this.desig = desig;
            this.sal = sal;

            double hra = .32 * sal;
            double da = .43 * sal;
            double ta = .45 * sal;

            double total = hra + da + ta + sal;

            Console.WriteLine("Employee number: " + empno);
            Console.WriteLine("Employee name: " + empnam);
            Console.WriteLine("Employee designation: " + desig);
            Console.WriteLine("Total Salary: " + sal);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter number");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string empnam = Console.ReadLine();
            Console.WriteLine("Enter employee designation");
            string desig = Console.ReadLine();
            Console.WriteLine("Enter basic salary");
            double sal = Convert.ToSingle(Console.ReadLine());
            emp.calculate_salary(empno, empnam, desig, sal);
        }
    }
}

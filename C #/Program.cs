﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_customer_create_method
{
    class Customer
    {
        int custno;
        string custname;
        string custadd;
        long custtel;

        public void getcustomerdata()
        {
            Console.WriteLine("enter customer no");
            custno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name");
            custname = Console.ReadLine();
            Console.WriteLine("enter customer address");
            custadd = Console.ReadLine();
            Console.WriteLine("enter customer telephone no");
            custtel = Convert.ToInt64(Console.ReadLine());

        }
        public void displaycustomerdata()
        {
            Console.WriteLine("custno " + custno);
            Console.WriteLine("custname " + custname);
            Console.WriteLine("custadd " + custadd);
            Console.WriteLine("custtel " + custtel);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object(instance) of Customer class
            //syntax classname objectname =new classname();
            Customer cust = new Customer();
            cust.getcustomerdata();
            cust.displaycustomerdata();
            Console.ReadLine();

        }
    }
}

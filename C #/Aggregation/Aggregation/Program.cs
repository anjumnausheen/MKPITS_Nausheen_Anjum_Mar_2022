using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Aggregation
{
    class Address
    {
        public string streetName;
        public string city;
        public int streetNo;
        public string email;


        public Address(string streetName, string city, int streetNo, string email)
        {
            this.streetName = streetName;
            this.city = city;
            this.streetNo = streetNo;
            this.email = email;


        }
     }
        class Student
        {
            public string name;
            public int age;
            public string country;
            public Address address;

            public Student(string name, string country, int age, Address address)
            {
                this.name = name;
                this.age = age;
                this.country = country;

                this.address = address;


            }

            public void printInfo()
            {
                Console.WriteLine("  name = " + name + "age= " + age + "  country = " + country + " city= " + address.city + " streetName = " + address.streetName + "   streetNumber= " + address.streetNo+ " \n  email =" + address.email);
            }
        }
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Address add1 = new Address(" Chhaoni ", " Nagpur  ", 10, " nausheenanjum2022@gmail.com ");

            Student stu = new Student(" Insha ", " India  ", 22, add1);

            stu.printInfo();
        }
    }
}

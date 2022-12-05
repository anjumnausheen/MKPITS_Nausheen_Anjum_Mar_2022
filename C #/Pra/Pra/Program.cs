using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Teacher Detail----------");
            
            Teacher tech = new Teacher(101,"Mickey","English");

            Console.WriteLine("-------Officer Detail");
            Officer off = new Officer("Class I",103,"Hari");

            Console.WriteLine("---------------Regular Details--------------");

            Regular reg = new Regular(100000,72,102,"Manish");

            Console.WriteLine("------------------Permanent Detail------------");
            Permanent per = new Permanent(200000,75,104,"Mangla");


            Console.ReadLine();
           
        }
        
}
    
  class Staff
    {
        public Staff(int c,string n)
        {
            Console.WriteLine("Code = "+c+"name= "+n);
        }
    }
    class Teacher:Staff
    {
        public Teacher(int c,string n,string s):base(c,n)
        {
            Console.WriteLine("Subject = " + s);
        }
    }
    class Typist:Staff
    {
        public Typist(int c, string n, int speed):base(c,n)
        {
            Console.WriteLine("Speed = " + speed);
        }
    }
    class Officer:Staff
    {
        public Officer(string grade,int c,string n):base(c,n)
        {
            Console.WriteLine("Grade = " + grade);
        }
    }
    class Regular:Typist
    {
        public Regular(int salary,int speed,int c,string n):base(c,n,speed)
        {
            Console.WriteLine("Salary = " + salary);
        }
    }
    class Permanent:Typist
    {
        public Permanent(int payment,int speed,int c,string n):base(c,n,speed)

        {
            Console.WriteLine("Payment =" + payment);
        }
    }


    
   
        
    
}

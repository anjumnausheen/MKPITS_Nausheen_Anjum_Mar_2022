using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_thirteen_parameterized_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Teacher Details*************");

            Teacher tech = new Teacher("English", 101, "Mickey");

            Console.WriteLine("*******Officer Details*************");
            Officer off = new Officer("Class I", 103, "Hari");

            Console.WriteLine("*******Regular Details*************");
            Regular reg = new Regular(50000, 7007, 102, "Shyam");

            Console.WriteLine("*******Permanent Details*************");
            Permanent pay = new Permanent(100000, 12, 103, "Hari");

           /* Calculator cl = new Calculator();
            cl.add();*/

            Console.ReadLine();


        }

        class Staff
        {
            public Staff(int c, string n)
            {
                Console.WriteLine("Code = " + c + " name = " + n);
            }
        }

        class Teacher : Staff
        {
            public Teacher(string subject, int code, string name) : base(code, name)
            {
                Console.WriteLine("Subject=" + subject);
            }
        }
        class Typist : Staff
        {
            public Typist(int speed,int code,string name):base(code,name)
            {
                Console.WriteLine("speed="+speed);

            }
        }
        class Officer:Staff
        {
            
            public Officer(string grade,int code,string name):base(code,name)
            {
                Console.WriteLine("grade="+grade);
            }
        }
        class Regular : Typist
        {
            public Regular(int salary,int speed,int code,string name):base(speed,code,name)
            {
                Console.WriteLine("Salary="+salary);
            }
        }
        class Permanent:Typist
        {
            public Permanent(int payment,int speed,int code,string name):base(speed,code,name)
           {
                Console.WriteLine("payment="+payment);
           }
       }

    }
}

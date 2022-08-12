using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_car_create_method
{
    class Car
    {
        int model;
        String make;

        //creating methods
        public void getcardata(int a, String b)
        {
            model = a;
            make = b;


        }
        public void displaycardata()
        {
            Console.WriteLine("model " + model);
            Console.WriteLine("make " + make);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object(instance) of Car class
            //syntax classname objectname =new classname();
            Car cr = new Car();
            Console.WriteLine("enter Car model");
            int model = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Car Make");
            String make = Console.ReadLine();


            cr.getcardata(model, make);
            cr.displaycardata();

            Console.ReadLine();

        }
    }
}

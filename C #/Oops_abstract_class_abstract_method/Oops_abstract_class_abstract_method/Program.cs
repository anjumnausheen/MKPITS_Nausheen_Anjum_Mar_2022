using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_abstract_class_abstract_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec=new Rectangle();  

            Circle cir =new Circle();

            Triangle tri=new Triangle();

            rec.area();
            cir.area();
            tri.area();

            Console.ReadLine();

        }
    }
    abstract class Shapes
    {

        abstract public void area();

  
    }
    class Rectangle:Shapes
    {
        public  override void area()
        {
            Console.WriteLine("This is area function of abstract class Rectangle");
        }
    }
    class Circle:Shapes
    {
        public  override void area()
        {
            Console.WriteLine("This is area function of abstract class Circle:");
        }
    }
    class Triangle:Shapes
    {
        public override void area()
        {
            Console.WriteLine("This is area function of abstract class Triangle");
        }


    }

}

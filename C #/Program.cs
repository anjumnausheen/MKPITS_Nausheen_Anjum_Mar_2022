using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_circle
{
    class Circle
    {
        public float radi;

        public void Calculatearea(float radi)
        {
            this.radi = radi;
            float res = 3.142f * radi * radi;
            Console.WriteLine("Area of Circle=" + res);

        }
        public void Calculatecir(float radi)
        {
            this.radi = radi;
            float res = 2 * 3.142f * radi;
            Console.WriteLine("Circumference of Circle=" + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            Console.WriteLine("enter radius of circle");
            float rad = Convert.ToSingle(Console.ReadLine());
            cir.Calculatearea(rad);
            cir.Calculatecir(rad);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_product_with_constructor
{
    class Product
    {
        int proid;
        string proname;
        int price, quan;

        public Product()
        {
            proid = 5;
            proname = "Pen";
            price = 50;
            quan = 5;
        }
        public void display()
        {
            Console.WriteLine("pro id=" + proid);
            Console.WriteLine("pro name=" + proname);
            Console.WriteLine("pro quan=" + quan);
            Console.WriteLine("price=" + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadLine();
        }
    }
}

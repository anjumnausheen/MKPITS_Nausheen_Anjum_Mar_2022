using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Product_with_Constructor_with_Parameter
{
    class Product
    {
        int proid;
        string proname;
        int quan;
        int price;

        //creating a  constructor with no parameters
        public Product()
        {
            proid = 4;
            proname = "Pen";
            quan = 4;
            price = 20;
        }


        //creating a  parameterized constructor with 4 parameters
        public Product(int proid, string proname, int quan, int price)
        {
            Console.WriteLine("Constructor with parameter called");
            this.proid = proid;
            this.proname = proname;
            this.quan = quan;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("product id=" + proid);
            Console.WriteLine("pro name=" + proname);
            Console.WriteLine("pro quan=" + quan);
            Console.WriteLine("price=" + price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product(); //this will call constructor automatically
            p.display();

            Console.WriteLine("--------Product 1 details -------");
            Product p1 = new Product(5, "pencil", 5, 50);// this will call parameterized constructor
            p1.display();

            Console.WriteLine("-----------------Product 2 details ----------");
            Console.WriteLine("enter product id");
            int p11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name");
            String pnam1 = Console.ReadLine();
            Console.WriteLine("enter product quantity");
            int pquan1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product price");
            int pprice1 = Convert.ToInt32(Console.ReadLine());

            Product p2 = new Product(p11, pnam1, pquan1, pprice1);// this will call parameterized constructor
            p2.display();

            Console.ReadLine();

        }
    }
}

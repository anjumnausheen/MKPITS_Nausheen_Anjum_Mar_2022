using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Class_and_Parameterized_Constructor
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        //creating a  constructor with no parameters
        public Book()
        {
            bookid = 5;
            title = "dotnet";
            author = "harry";
            price = 500;
        }


        //creating a  parameterized constructor with 4 parameters
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("Constructor with parameter called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("bookid=" + bookid);
            Console.WriteLine("title=" + title);
            Console.WriteLine("author=" + author);
            Console.WriteLine("price=" + price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(); //this will call constructor automatically
            b.display();

            Console.WriteLine("--------book1 details -------");
            Book b1 = new Book(5, "d", "lusi", 1000);// this will call parameterized constructor
            b1.display();

            Console.WriteLine("-----------------book2 details ----------");
            Console.WriteLine("enter bookid");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            String title1 = Console.ReadLine();
            Console.WriteLine("enter author");
            String author1 = Console.ReadLine();
            Console.WriteLine("enter price");
            int price1 = Convert.ToInt32(Console.ReadLine());

            Book b2 = new Book(id1, title1, author1, price1);// this will call parameterized constructor
            b2.display();

            Console.ReadLine();
        }
    }
}

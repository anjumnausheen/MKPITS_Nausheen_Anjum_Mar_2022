using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_handling4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteToFile wr=new WriteToFile();
            wr.Data();
            Console.ReadLine();
        }
    }
    class WriteToFile
    {
        public void Data()
        {
            StreamWriter sw = new StreamWriter("best.txt");

            Console.WriteLine("Hello Nausheen");

            string str=Console.ReadLine();  

            sw.WriteLine(str);

            sw.Flush(); 

            sw.Close();
        }
    }
}

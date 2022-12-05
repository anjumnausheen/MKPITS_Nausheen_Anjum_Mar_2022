using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_handling5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile wr=new ReadFile();
            wr.DataReading();
        }
    }
    class ReadFile
    {
        public void DataReading()
        {
            StreamReader sr = new StreamReader("Geeks.txt");

            Console.WriteLine("Content of the file");

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            string str = sr.ReadLine();

            while(str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }
    }
}

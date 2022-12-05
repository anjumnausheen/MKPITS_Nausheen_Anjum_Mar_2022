using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Program to read from a file using StreamReader class
namespace File_handling3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileRead wr=new FileRead();
            wr.ReadData();

        }
    }
    class FileRead
    {
        public void ReadData()
        {
            FileStream fs=new FileStream("Nausheen.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr=new StreamReader(fs);
            Console.WriteLine("Program to show content of test file");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str=sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine(str);
                str=sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
            fs.Close();

        }
    }
}

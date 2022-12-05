using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading_Application_One
{
    internal class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child Thread starts");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main:Creating the child thread");
            Thread childThread = new Thread(childref);

            childThread.Start();
            Console.ReadLine();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    
    internal class Class1
    {
        public static void M1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 1  " + i);
                Thread.Sleep(300);
            }
            Console.WriteLine("end method----------------");
        }
        static void Main(string[] args)
        {
            
            Thread thr= new Thread(M1);
            thr.Start();
            Thread thr1 = new Thread(M1);
            thr1.Start();
            Console.WriteLine("Main Method");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("thread " + i);
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop
{
    internal class Fibonacci_series   //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the number");
            int x=Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c;
            for(int i=0;i<=x;i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video.NewFolder
{
    internal class _7
    {   //call by referance
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            Console.WriteLine($"Befour Swap a={a} b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"Befour Swap a={a} b={b}");
        }
    }
    
}

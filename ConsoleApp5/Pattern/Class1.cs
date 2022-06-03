using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Pattern
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number R");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number C");
            int b = Convert.ToInt32(Console.ReadLine());
             
             for(int i=1;i<=a;i++)
            {
                for(int j=0;j<=b;j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine("");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to find maximum between three numbers (ok)
namespace Homework.Conditional_statements
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A=");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B=");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number C=");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a>b)&&(a>c))
                    {
                Console.WriteLine("max of A=" + a);
                    }   
            else if ((b>a) && (b>c))
            {
                Console.WriteLine("max of B=" + b);
            }
            else if((c>a) && (c > b))
                    {
                Console.WriteLine("max of C=" + c);
            }
        }
    }
}

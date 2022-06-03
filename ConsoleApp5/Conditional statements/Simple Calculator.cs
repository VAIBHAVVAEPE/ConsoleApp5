using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Conditional_statements
{
    internal class Simple_Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number a=");
            float a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the number b=");
            float b = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("1= add, 2= sub,3=multi,4=div");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            { 
                case 1: Console.WriteLine("addition is=" + (a + b));
                break;
            case 2: Console.WriteLine("sub is=" + (a - b));
                break;
            case 3:
                Console.WriteLine("Multi is=" + (a * b));
                 break;
            case 4:
                Console.WriteLine("divi is=" + (a + b));
                break;


            }
        }  
    }
}

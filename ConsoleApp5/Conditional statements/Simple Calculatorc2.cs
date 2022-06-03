using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Conditional_statements
{
    internal class Simple_Calculatorcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number a=");
            float a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the number b=");
            float b = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("1= add, 2= sub,3=multi,4=div");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c == 1)
            {
                Console.WriteLine("add is" + (a + b));
            }
            else if(c == 2)
            {
                Console.WriteLine("sub is"+(a-b));
            }
            else if(c==3)
            {
                Console.WriteLine("Multi is" + (a * b));
            }
            else if (c == 4)
            {
                Console.WriteLine("Divid is" + (a / b));
            }
        
        }
    }
}

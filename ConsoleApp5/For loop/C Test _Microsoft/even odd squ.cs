using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//to print number from 1 to 50 if number is even then print as it is and is odd then print its square
namespace Homework.For_loop.C_Test__Microsoft
{
    internal class even_odd_squ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number b");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = 0,squ;
          for (int i=a;i<=b;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even number" + i);
                }
                { 
               
                    sum = (i * 2) - 1;
                    squ = sum * sum;
                    Console.WriteLine("odd number" + squ);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//accept 2 number and find common Factorial  (ok)
namespace Homework.For_loop
{
    internal class Common_factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number A=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B=");
            int b = Convert.ToInt32(Console.ReadLine());
            int Min;
            
            if (a < b)                 //((or this use))int Min=a<b?a:b;
                 Min = b;
            else
                Min = a;

            for (int i = 1; i <=Min; i++)
            {
                

                if (a % i == 0 && b % i == 0)
                        
                    Console.WriteLine(i);
                
            }
            


        }
    }
}

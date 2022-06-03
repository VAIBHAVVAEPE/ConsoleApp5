using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 
// Factorial sum 1!+2!+3!+....+n!  (ok)
namespace Homework.For_loop.For_loop_que
{
    internal class Factorial_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number =");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum=1,add=0;
            for(int i=1;i<=x;i++)
            {
                
                sum = (sum * i);
                add = add + sum;

            }
            Console.WriteLine("addition of factorial="+add);
            Console.WriteLine("sum of factorial="+sum);
        }
    }
}

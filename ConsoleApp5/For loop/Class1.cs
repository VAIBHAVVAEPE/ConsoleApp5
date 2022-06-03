using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2,5,10,17,26,37,50.....nterms  (ok)
namespace Homework.For_loop
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
           for(int i=1;i<=x;i++)
            {
                sum = (i * i) + 1;
                Console.WriteLine(sum);
            }
            
        }
    }
}

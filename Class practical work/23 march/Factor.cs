using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Factor=Remender come always zero 
//10===1,2,5,10 are factor and count is also show   (ok)
namespace Class_practical_work._23_march
{
    internal class Factor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    c++;
                }
                
            }
            Console.WriteLine("count="+c);
        }
       
        
    }
}

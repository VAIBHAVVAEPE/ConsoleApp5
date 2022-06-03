using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Class_practical_work._23_march
{
    internal class Prime_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = 0;

              for(int i=2;i<=a/2;i++)
              {
                if (a%i==0)
                {
                   b++;
                 
                }
              }
                if (b == 0)
                {
                Console.WriteLine("prime number=");
                }
                else
                { 
                Console.WriteLine("not prime number"); 
                }
        }
    }
}

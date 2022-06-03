using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// write the program to count number of digits in any number  (ok)
namespace Homework.For_loop.For_loop_que
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Digit");
            int x = Convert.ToInt32(Console.ReadLine());
            int c = 0;
           while( x>0)
            {
                int digit = x / 10;
                x= digit;
                c++;
            }
                Console.WriteLine("count"+c);
            
        }
        
    }
}

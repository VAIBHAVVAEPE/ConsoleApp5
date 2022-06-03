using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// write the program to product of digit of any number  
namespace Homework.For_loop.For_loop_que
{
    internal class Que9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit=");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum1,digit=1;
            while (a > 0)
            {
                sum1 = a % 10;

                digit = digit * sum1;
                a = a / 10;
            }
                Console.WriteLine("product of digit="+digit);

            
           
        
        }

    }
}

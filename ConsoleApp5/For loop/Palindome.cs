using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop
{
    internal class Palindome
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n;
            int red;
            int dig=0;
            while (n > 0)
            {
                red = n % 10;
                dig = (dig * 10) + red; ;
                n = n / 10;
                
            }
            
            if (a==dig)
            {
                Console.WriteLine("pali");

            }
            else
                {
                Console.WriteLine(" not pali");
            }
            Console.ReadLine();



        }
    }
}

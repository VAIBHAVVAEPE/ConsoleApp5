using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  wap to find given number is harshad niven number or not
 Eg 18 sum=9
      18 is divisibal by 9*/ 
namespace Homework.For_loop.For_loop_que
{
    internal class Harshad_Niven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int rem,sum=0,temp=n;
            while (n > 0) 
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }
            if (temp%sum==0)
                Console.WriteLine("IT is Harshad_Niven number");
            else
                Console.WriteLine("IT is not Harshad_Niven number");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop.For_loop_que
{
    internal class palindrome //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int a=Convert.ToInt32(Console.ReadLine());
            int temp = a,rem,result=0;
             
            while(a!=0)
            {
                rem = a % 10;
                result = (result * 10) + rem;
                a = a / 10;
            }
            if (temp==result)
            {
                Console.WriteLine("it is palindrome =");
            }
             else
                Console.WriteLine("it is not palindrome =");


        }
    }
}

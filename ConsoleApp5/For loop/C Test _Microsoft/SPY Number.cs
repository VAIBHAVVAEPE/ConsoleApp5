using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write a program to check givn number is spy number or not
//eg. 123 =1+2+3=6  and 1*2*3=6
namespace Homework.For_loop.C_Test__Microsoft
{
    internal class SPY_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n,rem1,product=1,sum=0,rem2;

            while(n>0)
            {
                rem1 = n % 10;
                product = product * rem1;
                n = n / 10;
            }
            while(m>0)
            {
                rem2 = m % 10;
                sum = sum + rem2;
                m = m / 10;
            }
            if (product == sum)
                Console.WriteLine("spy");
            else
                Console.WriteLine("not");
        }
    }
}

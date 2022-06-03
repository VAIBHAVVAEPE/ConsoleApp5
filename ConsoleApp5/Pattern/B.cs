using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Pattern
{
    internal class B
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<=num;i++)    //   i=0,1,2,3,4,5   i=123456
            {
                //i=0j=  

                for (int j = 0; j <= num; j++)

                {
                    if (j == 0 || i == 0 || i == num / 2 || i==num||j==num)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                 Console.WriteLine("");  

            }
            Console.ReadLine();
        }
    }
}

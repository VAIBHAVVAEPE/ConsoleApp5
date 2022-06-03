using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Pattern
{
    internal class D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= num; j++)
                {
                    
                    if (j==0||i==0||i==num||j==num)
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

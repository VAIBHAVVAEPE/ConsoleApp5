using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//1.Write a program to print even numbers from 121 to 229 using for loop.   (ok)
namespace Homework.For_loop.For_loop_que
{
    internal class Que_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entter the number A=");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entter the number Y=");
            int y = Convert.ToInt32(Console.ReadLine());
           // int x = 121, y = 229;
            int num =0;
            for (int i = x; i <= y; i++)
            {
                num = (i % 2);


                if (num == 0)

                    Console.WriteLine("Even number=" + i);

                else
                    Console.WriteLine("NOT even=" + i);
            }
            
        }
    }
}

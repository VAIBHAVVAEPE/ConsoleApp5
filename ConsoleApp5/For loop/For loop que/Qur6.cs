using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//write the program to find the sum of all even number between 1 to n
namespace Homework.For_loop.For_loop_que
{
    internal class Qur6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 2; i <= a; i=i+2)
            {
                sum = sum+i;
            }
            Console.WriteLine(sum);
        }       
    }
}

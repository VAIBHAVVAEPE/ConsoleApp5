using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////write the program to find the sum of all odd number between 1 to n
namespace Homework.For_loop.For_loop_que
{
    internal class Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number =");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i=1;i<=x;i++)
            {
                sum = sum+((2 * i) - 1);
            }
            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop
{
    internal class Factorial   //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i=1;i<=a;i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("the factorial is=" + sum);
        }
    }
}

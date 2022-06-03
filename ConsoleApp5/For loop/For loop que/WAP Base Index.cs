using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop.For_loop_que
{
    internal class WAP_Base_Index
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the Base of number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter the Index of number");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum=1;
            for (int i=1;i<=x;i++)
            {
                sum = sum * b;
            }
            Console.WriteLine(sum);
        }
    }
}

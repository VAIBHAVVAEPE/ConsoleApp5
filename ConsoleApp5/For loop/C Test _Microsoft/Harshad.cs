using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop.C_Test__Microsoft
{
    internal class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem;
            int temp = x;
            while (x > 0)
            {
                rem = x % 10;
                sum = sum + rem;
                x = x / 10;
            }
            Console.WriteLine($"sum of digit={sum}");
            if (temp%sum==0)
                Console.WriteLine("harshad");
            else
                Console.WriteLine("not harshad");
        }
    }
}

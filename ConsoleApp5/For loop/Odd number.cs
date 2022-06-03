using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//odd number(ok)
namespace Homework.For_loop
{
    internal class odd_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=num;i++)
            {
                sum = ((2 * i) - 1);
                Console.WriteLine(sum);
            }







         }
    }
}

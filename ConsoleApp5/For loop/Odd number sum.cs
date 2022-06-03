using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sum of n odd number
namespace Homework.For_loop
{
    internal class Odd_number_sum
    {
        static void Main(String[]args)
        {

            Console.WriteLine("Enter the number A=");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 1; i <= a; i++)

            {
                sum = sum + ((2 * i) - 1);

            }

                Console.WriteLine(sum);
            
        }
    }
}

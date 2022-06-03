using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Write the program to print odd number 512 to 229 while loop
namespace Homework.For_loop.For_loop_que
{
    internal class Que_2S
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number at end A");
            int num = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("enter the number  of start B");
             int i= Convert.ToInt32(Console.ReadLine());
            int mix;
            if (num > i)
                mix = num;

            else
                mix = i;

            int c = 0;
            
            while(i<mix)
            {
                c++;
                int y = (2 * i) - 1;
                Console.WriteLine(i);
                i++;

            }
            Console.WriteLine("count"+c);
        }
    }
}

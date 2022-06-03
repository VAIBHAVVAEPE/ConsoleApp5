using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooo
{
    internal class Class333
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int next = a % 10;
            a = a / 10;
            int prev;
            bool inc = true;
            bool dec = true;
            while (a > 0)
            {
                prev = a % 10;
                if (prev > next)
                {
                    inc = false;
                }
                else if (prev < next)
                {
                    dec = false;
                }
                a = a / 10;
                next = prev;
            }
            if (inc == true)
                Console.WriteLine("Increament");
            else if (dec == true)
                Console.WriteLine("Decreament");
            else if (inc == false || dec == false)
                Console.WriteLine("Bouncy");

        }
    }
}

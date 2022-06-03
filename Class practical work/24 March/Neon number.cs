using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._24_March
{
    internal class Neon_number     //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int x=Convert.ToInt32(Console.ReadLine());
            
            int squ = x * x,sum=0;
            while (squ > 0)
            {
                int digit = squ % 10;
                sum = sum + digit;
                
                squ = squ / 10;
            }
            if (sum==x)
                Console.WriteLine("The number is Neon number");
            else
                Console.WriteLine("The number is NOT Neon number");
        }
    }
}

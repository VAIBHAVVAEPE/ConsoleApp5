using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop.C_Test__Microsoft
{
    internal class ReadBlue_factor
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the number A=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number B=");
            int y = Convert.ToInt32(Console.ReadLine());


            for (int i=x;i<=y;i++)
            {
               if(y% i==0)
                {
                    Console.WriteLine(i);
                    
                }
                

            }
        }
    }
}

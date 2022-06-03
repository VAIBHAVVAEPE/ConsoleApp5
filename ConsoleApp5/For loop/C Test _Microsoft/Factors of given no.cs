using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.For_loop.C_Test__Microsoft
{
    internal class Factors_of_given_no
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number =");
            int x = Convert.ToInt32(Console.ReadLine());
            
           
            for(int i=1;i<=x;i++)
            {
               if(x% i==0)
                {
                    Console.WriteLine(i);
                    
                }
                

            }
            

        }
    }
}

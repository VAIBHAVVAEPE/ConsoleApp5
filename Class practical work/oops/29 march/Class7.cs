using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{
  /*  1
     12
    123
   1234
  12345
     *      
    
    */

    internal class Class7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)

            {
                for (int s = 1; s <= 5-i; s++)
                {
                    Console.Write(" ");
                }
            
            for (int j = 1; j <= i; j++)
                { 
                    
                    Console.Write(j);
                }

                Console.WriteLine();    
            }
        }
    }     /*       6
                  56
                 456
                3456
               23456
              123456
           */
    class Class7a
    {
        static void Main(string[] args)
        {
            for (int i = 6; i >= 1; i--)

            {
                for (int s = 1; s <= i+1; s++)                           
                {
                    Console.Write(" ");
                }

                for (int j = i; j <= 6; j++)
                { 

                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }

    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{
    internal class Class8
    {/*
      #
      ###
      #####
      #######
    */
      
        
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 1; i <= num; i=1)

                {/*
                    for (int s = 1; s <= num-1; s++)
                    {
                        Console.Write(" ");
                    }
                */

                    for (int j = 1; j <= i; j++)
                    {

                        Console.Write("#");
                    }
                    
                    Console.WriteLine();
                    
                }
            }
        


    }
}

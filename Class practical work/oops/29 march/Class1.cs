using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("*");

                    else

                        Console.Write("$");
                }
                    Console.WriteLine();
                
            }
        }
       
    }



    internal class ClassA
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("*");

                    else

                        Console.Write("$");
                }
                Console.WriteLine();

            }
        }

    }

}

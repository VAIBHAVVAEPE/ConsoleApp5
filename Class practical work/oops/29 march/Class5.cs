using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{/*
  * A
  * AB
  * ABC
  * ABCD
  * ABCDE
  */
    internal class Class5
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);

                }

                Console.WriteLine("");
            }

        }

    }


    /*  
    ABCDE
    ABCD
    ABC
    AB
    A
  
     */
class Class5a
    {
        static void Main(string[] args)
        {

            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);

                }

                Console.WriteLine("");
            }
        }
    }

}




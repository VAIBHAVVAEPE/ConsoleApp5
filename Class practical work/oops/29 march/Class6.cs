using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{/*
ABCDE
BCDE
CDE
DE
E
    */
    internal class Class6
    {static
         void Main(string[] args)
        {

            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(j);

                }

                Console.WriteLine("");
            }
        }
    }
    /*
AAAAA
BBBB
CCC
DD
E
    */
    internal class Class6a
    {
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = i; j <= 'E'; j++)
                {
                    Console.Write(i);

                }

                Console.WriteLine("");
            }
        }
    }
    /*   
     *   EDCBA
     *   EDCB
     *   EDC
     *   ED
     *   E
     */
    internal class Class6b
    {
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                {
                    Console.Write(j);

                }

                Console.WriteLine("");
            }
        }
    }
}

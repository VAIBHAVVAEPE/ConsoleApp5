using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{/*
  * 
12345
1234
123
12
1
  */
    internal class Class4
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

    }

    /*
  1
  12
  123
  1234
  12345
     */
    internal class Class4a
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
/*
    1
    21
    321
    4321
    54321*/
    internal class Class4b
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    /*    12345
          2345
          345
          45
          5
     */
    class Class4c
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }
    /*11111
      2222
      333
      44
      5
     */
    class Class4d
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
        }
    }/*
      * 1
        22
        333
        4444
        55555
      */
    class Class4e
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}


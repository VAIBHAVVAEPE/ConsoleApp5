using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Practice_mock.NewFolder
{
    internal class Class3
    {/*11111
       2222
       333
       44
       5
      */
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


    class Class3a
    {/*12345
       1234
       123
       12
       1
      */
        static void Main(string[] args)
        {

            for (int i = 5; i >=1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
           

        }
    }
    /*12345
      2345
      345
      45
      5
     */
    class Class3c
    {
        static void Main(string[] args)
        {
             for(int i = 1; i <=5; i++)
            {
                for(int j = i; j <=5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
        }
    }/*55555
       4444
       333
       22
       1
      */
    class class3d
    {
        static void Main(string[] args)
        {
            for (int i=5;i>=1;i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
    /*54321
      5432
      543
      54
      5
     */

    class class3e
    {
        static void Main(string[] args)
        {
            for (int x=1;x<=5;x++)
            {
                for(int y=5;y>=x;y--)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
    }

    /*54321
      4321
      321
      21
      1
     */
    class class3f
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >=1; i--)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 1                   
 * 12
 * 123
 * 1234
 * 12345
 * 1
 * 22
 * 333
 * 4444
 * 55555
 * */
namespace Class_practical_work._29_march
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            for (int i=0;i<=10;i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    internal class Class3a
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

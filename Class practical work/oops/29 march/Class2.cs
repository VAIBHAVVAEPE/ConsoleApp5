using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._29_march
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        } 
    }

    internal class Classb
    {
        static void Main(string[] args)
        {
            for (int i=0;i<=10;i++)
            {
                for(int j=i;j<=10;j++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }

    }
}

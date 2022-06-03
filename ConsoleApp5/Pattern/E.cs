using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Pattern
{
    internal class E
    {
        static void Main(string[] args)
        {
            for (int i=0;i<=10;i++)
            {
                for(int j=0;j<=10;j++)
                {
                    if (j == 0 || i == 0 || i == 10 || i == 10 / 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}

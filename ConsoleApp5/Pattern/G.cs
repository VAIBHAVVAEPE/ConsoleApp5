using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Pattern
{
    internal class G
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i==0||j==0||(i>=5 &&j==10)||i==10)
                    {
                        Console.Write("G");
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }
           
        }
           
    }
}

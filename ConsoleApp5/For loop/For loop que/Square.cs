using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// wap to print squaer from 1 to 20
namespace Homework.For_loop.For_loop_que
{
    internal class Square
    {
        static void Main(string[] args)
        {
           
            int squ;
            for (int i=1;i<=20;i++ )

            {
                squ = i * i;
                Console.WriteLine(squ);
            }
        }
    }
}

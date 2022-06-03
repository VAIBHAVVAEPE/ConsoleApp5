using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*wap to check given no is automorphic or not
  int put= 25
    out put Automorphic
    as 25*25=625*/
namespace Homework.For_loop.For_loop_que
{
    internal class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int nub=Convert.ToInt32(Console.ReadLine());

            int squ = nub * nub;
            while(nub>0)
            {
                if (nub % 10 == squ % 10)
                {
                    nub = nub / 10;
                    squ = squ / 10;
                }
                else
                    break;

      
            }
            if (nub==0)
                Console.WriteLine("it is Automorphic");
            else
                Console.WriteLine("it is not Automorphic");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// write the program GCD and LCM of the given number  (ok)
namespace Homework.For_loop.For_loop_que
{
    internal class GCD_and_LCM  
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int nub1=Convert.ToInt32(Console.ReadLine());
            int nub2=Convert.ToInt32(Console.ReadLine());
            int b,sum,GCD,LCM;
            int a = nub1;
            b = nub2;
            while (b!=0)
            {
                sum=b;
                b= a % b;
                a=sum;
            }
            GCD = a;
            LCM = (nub1 * nub2) / GCD;
            Console.WriteLine("GCD=" + GCD);
            Console.WriteLine("LCM=" + LCM);
        }
    }
}

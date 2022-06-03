using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*wap to check given no is Krishnamurthy  or not
eg. 153=1!+5!+3!=153*/
namespace Homework.For_loop.For_loop_que
{
    internal class Krishnamurthy  //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int save, c, f,rem;
            save=n;
             while(n>0)
            {
                f = 1;
                c = 1;
                rem = n % 10;
                while (c <= rem)
                {
                    f = f * c;
                    c++;
                }
                sum = sum + f;
                n = n / 10;
              }
             if(save==sum)
                Console.WriteLine("Is Krishnamurthy number=");
             else
                Console.WriteLine("Is Not Krishnamurthy number=");
            
            
            
        }
    }
}

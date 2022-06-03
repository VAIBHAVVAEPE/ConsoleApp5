using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{//244   123
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num=");
            int n=Convert.ToInt32(Console.ReadLine());
            int red;
            int counte= 0;
            int counto = 0;
            while (n > 0)
            {
                red = n % 10;
                int dig = red;

                if (dig % 2 == 0)
                {
                    counte++;
                }
                else
                {
                    counto++;
                }
                n = n / 10;
            }
     
               Console.WriteLine("eve =" + counte);
               Console.WriteLine("odd =" + counto);
    
               Console.ReadLine();
        }
    }
}

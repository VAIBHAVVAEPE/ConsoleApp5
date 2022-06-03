using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//accept Base and Index ,and calculate  (ok)
namespace Homework.For_loop
{
    internal class Base_and_Index
    {
        static void Main(string[] args)
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
           
            int b = Convert.ToInt32(Console.ReadLine());
            int ans = 1;
            for(int i=1;i<=b;i++)
            {
                ans = ans*a;
            }
            Console.WriteLine(ans);

        }


    }
}

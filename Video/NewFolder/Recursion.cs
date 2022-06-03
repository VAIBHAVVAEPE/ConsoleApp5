using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Recursion
namespace Video.NewFolder
{
    internal class Recursion
    { 
      public static int factorial(int n)
      {
         if (n == 1)
        {
            return 1;
        }
         else
        {
            int ans = factorial(n - 1);
            return n=ans;
        }
      }
      
    
    static void Main(string[] args)
    {
            Recursion obj=new Recursion();
            //obj.factorial(5)
    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(ok)
namespace Class_practical_work._23_march
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine(fact);


        }
        
        
    }
}

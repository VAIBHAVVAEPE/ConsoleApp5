using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1+2+3+4....+10 =sum of number  (0k)
namespace Class_practical_work._23_march
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1;i<=a;i++)
            {
                sum = sum + i;
            }
             
            Console.WriteLine(sum);
        }
    }
}

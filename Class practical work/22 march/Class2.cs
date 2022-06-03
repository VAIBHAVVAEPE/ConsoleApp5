using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//trenary concept
namespace Class_practical_work._22_march
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(y % 4 == 0 ? "leap":"Not leap");
            Console.ReadLine();

        }
    }
}

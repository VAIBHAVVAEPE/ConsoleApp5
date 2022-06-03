using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to Calculate Area and Parameter of Square
namespace Homework.ConsoleApp5
{ 
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side of Square");
           float side = Convert.ToSingle(Console.ReadLine());
            float area = (side * side);
            float parameter = (4 * side);
            Console.WriteLine("Parameter of square="+parameter);
            Console.WriteLine("Area of square="+area);
            Console.ReadLine();
            
        }
    }
}

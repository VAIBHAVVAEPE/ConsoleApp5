using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to check whether a year is leap year or not (ok)
namespace Homework.Conditional_statements
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter the year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            { 
             Console.WriteLine("leap year");
            }
                else 
            {

                Console.WriteLine("not leap year"); 
            }

        }
    }
}

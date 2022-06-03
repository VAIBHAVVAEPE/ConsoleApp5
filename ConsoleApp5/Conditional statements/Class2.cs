using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program to check whether a number is divisible by 5 and 11 or not 
namespace Homework.Conditional_statements
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a= Convert.ToInt32(Console.Read());
            if ((a % 5 == 0) && (a % 11 == 0))

            {
                Console.WriteLine("number is divisible by 5 & 11=");
            }
            else
            {
                Console.WriteLine("number is not divisible by 5 and 11=");

            }
              
            


        }
    }
}

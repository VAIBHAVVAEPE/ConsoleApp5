using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to accept a number(only three number digits )  and do sum of digits. 
namespace Homework.ConsoleApp5
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number=");
            int number=Convert.ToInt32(Console.ReadLine());
            
            int b= number % 10;
            int c= number / 10;
            int d = c % 10;
            int e= number / 100;

            float sum = e + b+d;

            Console.WriteLine("The sum of digits=" + sum);
            Console.ReadLine();

           
          

            
        }
    }
}

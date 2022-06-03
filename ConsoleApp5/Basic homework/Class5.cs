using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to accept amount from user and give discount of 20℅ and calculate net payable after discount
namespace Homework.ConsoleApp5
{ 
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Amount =");
            int a=Convert.ToInt32(Console.ReadLine());
            float Dis = a * 0.2f;
            float Net = a - Dis;

            Console.WriteLine("the discount net payable =" + Net);
            Console.ReadLine();
        }
    }
}

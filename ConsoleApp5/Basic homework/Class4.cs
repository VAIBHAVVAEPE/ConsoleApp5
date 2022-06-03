using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to accept name and 5 subject marks and find average.
namespace Homework.ConsoleApp5
{ 
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks of English=");
            int M1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Math=");
            int M2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of sci=");
            int M3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Phy=");
            int M4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Chi=");
            int M5= Convert.ToInt32(Console.ReadLine());
            float avg = (M1 + M2 + M3 + M4 + M5) / 5f;
            Console.WriteLine("avg of five subject="+avg);
            Console.ReadLine();

        }

    }
}

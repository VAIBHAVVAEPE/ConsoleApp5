using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// print table of given number 
namespace Homework.For_loop
{
    internal class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Table=");
            int a = Convert.ToInt32(Console.ReadLine());

            int table=1;
            for (int i = 1; i <= 10; i++)
            {
                {
                    table = a * i;
                }
                Console.WriteLine(table);
            }
        }
    } 
}

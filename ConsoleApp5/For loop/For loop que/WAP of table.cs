using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// wap to print table of any number
namespace Homework.For_loop.For_loop_que
{
    internal class WAP_of_table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the nubmber");
            int a=Convert.ToInt32(Console.ReadLine());
            int table;
             for (int i=1;i<=10;i++)
            {
                table = i * a;
                Console.WriteLine(table);
            }
                
        }
    }
}

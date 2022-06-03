using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work._24_March
{
    internal class Read_back  //(ok)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int d = 0; //this is use for count
             while(num>0)

            {
                d++;
                int x = num % 10;
                Console.Write(x);
                num = num / 10;
            }
            Console.WriteLine(num);
            Console.WriteLine("count"+d);
        }
    }
}

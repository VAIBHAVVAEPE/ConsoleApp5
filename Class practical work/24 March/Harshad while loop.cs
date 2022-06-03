using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Enter the number and find it is Harshad number   (0k)
namespace Class_practical_work._24_March
{
    internal class Harshad_while_loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int b = a;
            while (a > 0)
            {
                int q = a % 10;
                sum = sum + q;
                a = a / 10;
            }
            Console.WriteLine(sum);
            /*int z = b % sum;
           int z == 0 ? "Harshad" : "Not Harshad";*/
            if (b % sum == 0)
            { 
            Console.WriteLine("Harshad");
             }
            else
                Console.WriteLine("Not Harshad");

        }
    }
}

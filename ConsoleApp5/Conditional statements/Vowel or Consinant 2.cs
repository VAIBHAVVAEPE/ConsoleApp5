using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Conditional_statements
{
    internal class Vowel_or_Consinant_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the alphabet");
            char n=Convert.ToChar(Console.ReadLine());
           
            if (n=='a'|| n == 'e' || n == 'i' || n == 'o' || n == 'u')
            {
                Console.WriteLine("it is vowel");
            }
            else
            {
                Console.WriteLine("it is Consinant");
            }
        }
    }
}

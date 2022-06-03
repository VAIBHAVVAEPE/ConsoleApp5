using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Conditional_statements
{
    internal class Vowel_or_Consinant
    {
        static void Main (string[]args)
        {
            Console.WriteLine("Enter the alphabet");
             char n = Convert.ToChar(Console.ReadLine());
            
           

            switch (n)
            {
                case 'a':Console.WriteLine(" it is vowel ");
                    break;
                case 'e': Console.WriteLine("it is vowel ");
                    break ;
                case 'i': Console.WriteLine("it is vowel ");
                    break;
                case 'o': Console.WriteLine("it is vowel ");
                    break;
                case 'u': Console.WriteLine("it is vowel ");
                    break;
                   default: Console.WriteLine("it is consinant");
                    break;
            }
        }
    }
}

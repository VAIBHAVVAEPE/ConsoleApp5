using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//upper case to lower case problem (ok)
namespace Class_practical_work._22_march
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabit");

            char ch = Convert.ToChar(Console.Read());

            if (ch >= 65 && ch <= 90)
            {
                ch = (char)(ch + 32);
                Console.WriteLine("upper"+ch);
            }
            else if (ch >= 97 && ch <=122)
            {
                ch = (char)(ch - 32);
                Console.WriteLine("lower"+ch);
            }
            else
            {
                Console.WriteLine("It not Alphabit");
            }
        }

           




        
    }
}

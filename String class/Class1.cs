using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String111_class
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name ==");
             string s=Console.ReadLine();

           s.ToUpper();
            Console.WriteLine(s);
            for(int i=0;i<s.Length;i++)
            {

                Console.WriteLine(s[i]);
            }
            



        }
    }
}

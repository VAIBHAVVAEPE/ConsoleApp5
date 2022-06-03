using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class inf
    {
        public int a, b, y;
        public int sum;
        public float p, r, n, simint;
        public void add()
        {
            Console.WriteLine("enter the value a and b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("addition is="+sum);

        }
        public float Simpleinterest()
        {
            Console.WriteLine("enter the value of principal,rate of intrest,year");
            float p = Convert.ToSingle(Console.ReadLine());
            float r = Convert.ToSingle(Console.ReadLine());
            float n = Convert.ToSingle(Console.ReadLine());
            simint = (p * r * n) / 100;
            Console.WriteLine("the simple intreat"+simint);

            return 0;
        }
        public void leap()
        {
            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4) == 0)
            {
                Console.WriteLine("It is Lip Year");
            }
            else
            {
                Console.WriteLine("It is not lip year");
            }

            
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            inf obj = new inf();
            obj.add();
            obj.Simpleinterest();
            obj.leap();

        }
    }
}

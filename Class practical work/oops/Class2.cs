using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{

    class inf
    {
         int a, b, y;
         int sum;
         float p, r,n,simint;
        public void add()
        {
            Console.WriteLine("enter the value a and b");
            int a=Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine(sum);

        }
        public float Simpleinterest()
        {
            Console.WriteLine("enter the value of principal,rate of intrest,year");
            float p = Convert.ToSingle(Console.ReadLine());
            float r = Convert.ToSingle(Console.ReadLine());
            float n = Convert.ToSingle(Console.ReadLine());
            simint = (p * r * n) / 100;
            Console.WriteLine(simint);

            return 0;
        }
        public bool leap()
        {

            Console.WriteLine("enter the year");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4) == 0) 
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            return true;
        }
    }
    internal class Class2
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

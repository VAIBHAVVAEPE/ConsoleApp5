using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegataNew
{

    //static method
    internal class Class1
    {
        public static void factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
                Console.WriteLine("fact " + fact);
            }
        }
        public static void squre(int x)
        {
            int squ = x + x;
            Console.WriteLine("squre" + squ);
        }
    }
    public delegate void mydelegate(int c);
    class Program
    {

        static void Main(string[] args)
        {
            mydelegate obj = Class1.factorial;
            obj = obj + Class1.squre;
            obj(4);

        }
    }






    class A
    {
        public delegate int mydelegate1(int x, int y);
        public static int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static void Main(string[] args)
        {
            mydelegate1 f = add;
            int a = f(20, 10);
            Console.WriteLine(a);

        }
    }




    //instant method
    class B
    {
        public void add(int a, int b)
        {
            int add = a + b;
            Console.WriteLine("add  " + add);
        }
        public void sub(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine("sub  " + sub);
        }
        public void product(int a, int b)
        {
            int product = a * b;
            Console.WriteLine("product  " + product);
        }
    }
    public delegate void del(int x, int y);


    class Mainprog
    {
        static void Main(string[] args)
        {
            B ob = new B();

            del fun = ob.add;
            fun = fun + ob.sub;
            fun = fun + ob.product;


            fun(4, 3);

        }
    }

    //Anonymous Function

    public delegate void mydele(int x, float b);
    class AA
    {
        public static void Add(int a, float b)
        {
            float sum = a + b;
            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            mydele d1 = Add;
            d1(10, 10.5f);

        }
    }




























































    class PPP
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] % 2 != 0)
                {
                    sum = sum + arr[k];
                }
            }
            Console.WriteLine(sum);
        }
    }

    class AAA
    {//welcome to India ,India is a country like other countries like USA,Japan
        static void Main(string[] args)
        {
            string st = "welcome to India India is a country like other countries like USA Japan";
            string[] arr = st.Split(" ");
            
            for (int k = 0; k < arr.Length; k++)
            {
                int count = 1;
                //Console.WriteLine(arr[k]);
                for (int h = k + 1; h < arr.Length; h++)
                {
                    if (arr[k] == arr[h])
                    {
                        count++;
                       
                    }
                }
                if (count > 1   )
                {
                    Console.WriteLine(arr[k]);
                }
            }


        }
    }
    internal class ArrayPrac
    {
        static void Main(string[] args)
        {


            string s1 = "welcome to India India is a country like other countries like USA Japan";
           // string s1 = s.ToLower();
            string[] s2 = s1.Split(' ');
            int count;
            for (int i = 0; i < s2.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < s2.Length; j++)
                {
                    if (s2[i]==(s2[j]))
                    {
                        count++;
                        //s2[j] = "0";

                    }

                }
                if (count > 1 )
                {
                    Console.WriteLine(s2[i]);
                }
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringggg
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string st = "vaibhav";
            Console.WriteLine(st[3]);
        }
    }


    class Class2
    {
        static void Main(string[] args)
        {
            string st = "ram vaibhav";

            int start = st.IndexOf("a");
            string lastname = st.Substring(start);
            Console.WriteLine(lastname);


            int a = 23;
            int b = 34;
            string str = (a > b) ? "a is greter" : "b is greter";
            Console.WriteLine(str);

            string[] aa = { "vai", "ram", "sham", "dfxvf" };

            Array.Sort(aa);
            for(int i = 0; i < aa.Length; i++)
            {
                Console.WriteLine(aa[i]);
            }

            foreach(string v in aa)
            {
                Console.WriteLine(v);
            }
        }
    }

    class Class22
    {
        static void Main(string[] args)
        {
            int[] arr = { -3444, -554, -2, -3, -45, -756, -44,-100 };


            Console.WriteLine(arr.Min());
            int abc=arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(abc > arr[j])
                    {
                        abc = arr[j];
                        //break;
                    }
                }

                //Console.WriteLine(arr[i]);
            }
            Console.WriteLine(abc);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (abc < arr[i])
                    {
                        abc = arr[j];
                        //break;
                    }
                }

                //Console.WriteLine(arr[i]);
            }
            Console.WriteLine(abc);

        }
    }


    class A
    {
         int g=10;
        public void add(int a,int b)
        {
            int d = a + b;
            Console.WriteLine("add="+d);
        }
        static void Main(string[] args)
        {

            //A.add(3,5);
            A obj=new A();
            obj.add(3,5);

        }
    }
    
    
    
}

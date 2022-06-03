using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ssssssss
{
    internal class NonGeneric
    {
        static void Main(string[] args)
        {
            List<int> a1 = new List<int>();
            a1.Add(234);
            a1.Add(43);
            a1.Add(43);


            List<int> a2 = new List<int>();
            a2.Add(2);
            a2.Add(34);
            a1.Insert(1, 1111);
            a1.AddRange(a2);

            foreach (int i in a1)
            {
                Console.WriteLine(i);
            }

        }


    }
    class Demo
    {
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>();
            a.AddLast(23);
            a.AddLast(44);
            a.AddLast(57);

            a.AddFirst(00);
            a.FindLast(2);
            LinkedListNode<int> noadeafter= a.Find(44);

            if(noadeafter!=null)
            {
                
            }
            
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
    class CoPrime
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());//4
            int b = int.Parse(Console.ReadLine());//8
            int c = 0;
            for(int i=1;i<=a && i<=b;i++)
            {
                if(a%i==0&& b%i==0)
                {
                    c++;
                }
            }
            if(c==1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not Co-Prime");
            }
        }
    }

    class SubArray
    {
        static void Main(string[] args)
        {
;
            int[] arr = new int[9];
            for(int i=0;i<=arr.Length-1;i++)
            {
                int n=int.Parse(Console.ReadLine());
                arr[i] = n;
            }
            int max = 0;
            int Zero = 0, ones = 0;

            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[j]==0)
                    {
                        Zero++;
                    }
                    if(arr[j]==1)
                    {
                        ones++; 
                    }
                    if(Zero==ones)
                    {
                        int t = j - i + 1;
                         max = t;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
    class CountOfArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of array");
            int m=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[m];
            for (int i = 0; i <= arr.Length-1;i++)
            {
                int n = int.Parse(Console.ReadLine());
                arr[i] = n;
            }
        }
    }
}

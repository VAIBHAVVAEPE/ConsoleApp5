using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooo
{   //array

    //print  array
    internal class Class22
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            int[] a = { 2, 3, 34, 54, 43 };
            //traditional
            for( int i=0;i<=arr.Length;i++)
            {
                Console.WriteLine(arr[i]+" ");
            }
            Console.WriteLine("////////////");
             for( int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]+" ");
            }
                
           

        }
    }                              
    class Class23
    {

        static public int Frqy(string s,char ch)
        {
            int c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == ch)
                    c++;

            }
            return c;
        }
        static void Main(string[] args)
        {
            string s = "vaibhav";
            string sesrch = "bhia";
            bool isfound=true;
            foreach(char c in sesrch)
            {
                int ori=Frqy(s,c);
                int sea=Frqy(sesrch,c);
                
                if (ori<sea)
                {
                    isfound = false;
                    break;
                }
            }
           
            if(isfound)
            {
                Console.WriteLine("string can be found");

            }
            else
            {
                Console.WriteLine("not");
            }
           
        }
    }

    class Class24
    {//12346789      meassing is 5
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 6, 7, 8, 9 };
            int x = 0;
            


            for (int i = 0; i < ar.Length; i++)
            {
                x=x+ar[i];
                
            }
            Console.WriteLine(x);

        }
    }
}

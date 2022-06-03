using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssssssss
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name ==");
            string? s = Console.ReadLine();

              string s1=s.ToUpper();             //upper case
            Console.WriteLine(s1);
            for (int i = 0; i < s.Length; i++)     //display single character
            {
                Console.WriteLine(s1[i]);
            }

            Console.WriteLine(" reverse=====");     //reverse character display
            for(int i=s1.Length-1;i>=0;i--)
            {
                Console.WriteLine(s[i]);
            }
        }

    }
    class Class2
    {
        static void Main(string[] args)
        {
            string ss = "VAIBHAV";

            string ss1 = ss.ToLower();            //lower cass
            Console.WriteLine(ss1);
            string ss2 ="Varpe";

            string ss3 = ss +" "+ ss2;     //concat
            Console.WriteLine(ss3);

        }
    }
    class Class3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the name===");
            string? a=Console.ReadLine();

            string s = a.Replace('a', 'z');      //replace
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            //string s = "india is my country";
            //string []a = s.Split(" ");
            //foreach(string word in a)
            //{
            //    for (int i = word.Length - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.Write(" ");

            //}
            //foreach(string word in a)
            //{
            //    char firstchar = word[0];
            //    string half = word.Substring(1);
            //    firstchar = char.ToUpper(firstchar);
            //    Console.Write(firstchar + half + " ");
            //}
            string s = "india is my country";
            string[] a = s.Split(" ");
            Console.WriteLine(" ========");
            for (int j = 0; j < a.Length; j++)///0= india
            {
                string word = a[j];
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Console.Write(word[i]);
                }
               // Console.Write(" ");
            }
            //for(int j=0;j< a.Length; j++)
            //{
            //    string add=a[j];
            //    int add1 =0;

            //    for(int i = add.Length; i >= 0; i++)
            //    {
            //        add1 = add[i] + add1;
            //    }

            //    Console.WriteLine(add1);
            //}
        }
    }

     class Class5
     {

        static void Main(string[] args)
        {
            Console.WriteLine("enter ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int max;

            if (a > b && a > c)
            {
                max = a;
                Console.WriteLine(max);
            }
            else if (b > a && b > c)
            {
                max = b;
                Console.WriteLine(max);
            }
            else if (c > a && c > b)
            {
                max = c;
                Console.WriteLine(max);
            }
        }
     }

    class Anageam
    {
        static void Main(string[] args)
        {
            string str = "keep";
            string str1 = "peek";

            string s1=str.ToLower();
            string s2=str1.ToLower();

            char[] chr1=s1.ToCharArray();
            char[] char2=s2.ToCharArray();

            Array.Sort(chr1);
            Array.Sort(char2);

            string newstring1=new string(chr1);
            string newstring2=new string(char2);

            if(newstring1.CompareTo(newstring2)==0)
            {
                Console.WriteLine("both are anagram");
            }
            else
            {
                Console.WriteLine("not anagram");
            }

        }
    }

    class A:B
    {
        int a;
        public   void Seta(int a)
        {
            this.a = a;
        }
        public int Geta()
        { 
        return this.a;
        }
        


        public void Fun()
        {
            Console.WriteLine("Class A");
        }

    }
    class B
    {
        int b;
        public int MyPropertyb { get; set; }
        public void Fun1()
        {
            Console.WriteLine("Class B");
        }

    }
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the number");
                int a=int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Divided my" + a / b);
            }
            catch(DivideByZeroException obj)
            {
                Console.WriteLine(  "Donot enter zero");
            }
            catch (FormatException obj1)
            {
                Console.WriteLine(obj1.Message);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hallo word");
            }
            

        }
    }



    class ErrorNumber
    {

    }
    class MobileNumber
    {

        static void Main(string[] args)
        {
            
            
                Console.WriteLine("enter the 10 digit number ");
                 long mb=long.Parse(Console.ReadLine());
                int c = 0;
                while(mb>0)
                {
                    c++;
                    mb = mb / 10;

                }
               if (c == 10)
               {
                Console.WriteLine("");
               }

                                           
        }
    }



    class DemoException
    {
        static void divide(int a,int b)
        {
            int result = a / b;
            Console.WriteLine("divide"+result);
        }
        static void Main(string[] args)
        {

        }

    }
}

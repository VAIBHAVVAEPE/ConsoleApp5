using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ABC
    {
        static void Main(string[] args)
        {
            Console.WriteLine("evter the number five number==");
            int[] a = new int[5];

            int even = 0;
            int odd = 0;


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("even" + even);
            Console.WriteLine("odd" + odd);

        }

    }
    class Add
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 4, 6, 4, 2, 5 };
            int[] c = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] + b[i];
                Console.WriteLine(c[i]);

            }

        }
    }


    class Merge
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };

            int[] c = new int[a.Length + b.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    c[i] = a[i];
            //    Console.WriteLine(c[i]);
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    c[i] = b[i];
            //    Console.WriteLine(c[i]);

            // or

            for (int i = 0; i < c.Length; i++)
            {
                if (i < a.Length)
                {
                    c[i] = a[i];
                }

                else
                {
                    c[i] = b[i - a.Length];
                }
                Console.WriteLine(c[i]);

            }
        }
    }


    class Merge1
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };

            int[] c = new int[a.Length + b.Length];
            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }



        }
    }

    class Merge2
    {
        //static void Main(string[] args)
        //{
        //    int[] a = { 1, 2, 3, 4, 5, 11, 12, 13 };
        //    int[] b = { 6, 7, 8, 9, 10 };

        //    int[] c = new int[a.Length + b.Length];

        //    for (int i = 0; i < a.Length; i++)
        //    { }


        //}
    }



    class Ass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number =");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());


            int[] x = new int[4];
            x[0] = a;
            x[1] = b;
            x[2] = c;
            x[3] = d;

            Console.WriteLine(x[0]);
            Console.WriteLine(x[2]);
            Console.ReadLine();



        }
    }
    class Ass1
    {
        static void Main(string[] args)
        {


            int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(" enter th number");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
        }
    }
    class ArrayMax
    {
        
       
    }


    class Abc
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 5, 36, 34, 6, 2, 6, 77, 55 };
            Console.WriteLine("find the number");
            int n=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<a.Length;i++)
            {
                if (n==a[i])
                {
                    Console.WriteLine("enter the position  "+i);

                }
            }
             
            //foreach(int r in a)
            //{
            //    Console.WriteLine(r+2);
            //}

            
        }
    }




    //WAP to add elements to single dimensional int array and print elements from 1D array

    class Prog1
    {
        static void Main(string[] args)
        {

            string[] a = new string[4] {"vai","ram","edf","aefdaef"};
            

            for(int i=0;i<a.Length;i++)
            {
                string s = a[i];
                Console.WriteLine(i);
            }
        }
    }

    //WAP to accept dimension of 1D array and create and accept data in that array.
    //Calculate the average value of array elements.

    class Prog2
    {
        static void Main(string[] args)
                {
                    Console.WriteLine("enter the size");
                    int y = Convert.ToInt32(Console.ReadLine());
            int[] xx = new int[y];
            Console.WriteLine("enter the number");
            int sum = 0;
            for (int i=0;i<xx.Length;i++)
            { 
                int a=Convert.ToInt32(Console.ReadLine());
                sum = sum + a;
            }
            int avg=sum/xx.Length;
            Console.WriteLine("sum ="+sum);
            Console.WriteLine("avg ="+avg);


        }
        
    }

    //WAP to search for a given number in an array and accordingly print the index if exists

    class Prog3
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the size ");
            int a = Convert.ToInt32(Console.ReadLine());

            int [] arr=new int[a];
            Console.WriteLine("enter the number");

            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ENTER THE NUMBER TO FIND INDEX VALUE=");
             int y=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (y == arr[i])
                {
                    Console.WriteLine("position of number=" + i);
                }

            }
            
        }
    }



    //WAP to copy an array by iterating the array.

    class Prog4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int a= Convert.ToInt32(Console.ReadLine()); 
            int [] arr=new int[a];
           
            int[] cw = new int[a];
            int k = 0;
            Console.WriteLine("enter the number=");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the value in new array is==");
            for (int i = 0; i < cw.Length; i++)
            {
                 cw[k++]=arr[i];

                Console.WriteLine(cw[i]+" ");
            }
            Console.ReadLine();
           



        }
    }
    //WAP to print reverse of an array. Also print every alternate element backwards.

    class Prog5///reverrse of number
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the size of array=");
            int a=Convert.ToInt32(Console.ReadLine());  
            int[] arr = new int[a];
            Console.WriteLine("enter the number=");

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[]rev=new int[a];
            Console.WriteLine("reverse number is==");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                rev[i] = arr[i];


                Console.WriteLine(rev[i]);
            } 
            
            
        }
    }

   class Prog55
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size  of array=");
            int a = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[a];
            Console.WriteLine("enter the char");

            for (int i=0;i<arr.Length;i++)
            {
                arr[i]=Convert.ToString(Console.ReadLine());

            }
                string [] rev=new string[a];
            for(int i=arr.Length - 1; i >= 0; i--)
            {
                rev[i]=arr[i];
                Console.WriteLine(rev[i]);
            }
        }
    }

    class Prog555//reverse single character
    {
        static void Main(string[] args)
        {
           string []arr =new string[7] ;
            //vaibhav
            string [] rev=new string[7] ;

            

            
        }
    }

    //WAP to insert an element in a specific position into an array.

    class Prog6
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 3];

            for( int i=0;i<4;i++)
            {
              //  Console.WriteLine("enter the"{a.Length}"of element");

            }
            
        }
    }




    class class12
    {
        static void Main(string[] args)
        {
            int[] arr = { 6,7,6,23,23,9,5,23,7,7,2 };


            for(int i=0;i<arr.Length;i++)
            {
                int count = 1;
                Boolean arr2 = false;

                for(int k=i-1;k>=0;k--)
                {
                    if(arr[i]==arr[k])
                    {
                        arr2=true;
                        break;
                    }
                }

                if (arr2 == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                }
                    if(count==1)
                    {
                        Console.WriteLine(arr[i]+"  "+count);
                    }
                
            }
        }
    }


   
    abstract class Car
    {
        int price;
        public abstract void start();
        
        public void color(string color)
        {
            Console.WriteLine(color);
        }
        
    }
    class Audi : Car
    {
        public override void start()
        {
            Console.WriteLine("Audi car is  start");
        }
        public Audi(string modal)
        {
            Console.WriteLine(modal);
        }

    }
    class BMW : Car
    {
        public override void start()
        {
            Console.WriteLine(" BMW car is  start");
        }
    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            Audi a1 = new Audi("123");
            a1.start();
            a1.color("read");
            

        }
    }

    class InterFaces
    {
        static void Main(string[] args)
        {
            Audie a1 = new Audie();
            a1.walk();
            a1.walk();

        }
    }
    class Audie:ICarr,IPerson
    { 
        public void start()
        {
            Console.WriteLine("Car is Stsrt");
        }
        public void walk()
        {
            Console.WriteLine("Car is walk");
        }
    }
    interface IPerson
    {
        void walk ();
    }
    interface ICarr

    {
        void start();

    }

    class AA
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            arr[0] = 3;
            arr[1] = 343;

            arr[2] = 3343;
            arr[3] = 543;
            arr[4] = 334;
            arr[5] = 53;

            foreach(int aa in arr)
            {
                Console.WriteLine(aa);
            }

        }
    }

    
}


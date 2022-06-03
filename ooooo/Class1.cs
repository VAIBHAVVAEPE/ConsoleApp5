using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooooo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            //even and odd

            Console.WriteLine("enter the number==");
            int a=Convert.ToInt32(Console.ReadLine());

            if (a%2==0)
            {
                Console.WriteLine(  "even");
            }
            else
            {
                Console.WriteLine("odd");
            }


        }
    }
     
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the 1 to ");
            int a=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=a;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("even"+i);
                }
                
            }
            for (int i = 1; i <= a; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd" + i);
                }

            }
            
        }   //12345
    }

    class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            long a=Convert.ToInt64(Console.ReadLine());
            long rem;
            long sum = 0,sum1=0;
            
            while (a>0)
            {
                 rem = a %10;
                if(rem%2==0)
                {
                    sum = sum + rem;  
                }
                else
                {
                    sum1 = sum1 + rem;
                }
               

                a = a/10;
            }
            Console.WriteLine("even sum==" + sum);
            Console.WriteLine("odd sum==" + sum1);
            Console.ReadLine();

        }
    }

    class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            long a = Convert.ToInt64(Console.ReadLine());
            long rem=a;
            
            long sum1=0;
            long sum = 0;
            

            while (a > 0)
            {                                                                    //12345
                rem = a % 10;                                                 //1+3+5==1+6+120=127  odd
                                                                              //2+4==2+24=26 even
                if (rem % 2 != 0)
                {
                    long digit = 1;
                    for (int i = 1; i <= rem; i++)
                    {
                        digit = digit * i;
                    } 
                    sum = sum + digit;
                }

                else
                {
                    long digit1 = 1;
                    for (int j = 1; j <= rem; j++)
                    {
                        digit1 = digit1 * j;

                    }
                    sum1 = sum1 + digit1;
                }
                a = a / 10;
            }
                Console.WriteLine("even factorial==" + sum1);
                 Console.WriteLine(" sum  odd factorial==" + sum);

        }
    }


    class Class5
    {
        static void Main(string[] args)                      //1.2,3,4,5
        {

          
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;


            //    for(int j = 1; j <=a; j++)
            //    {
            //        fact = fact * j;

            //     Console.WriteLine(fact);

            //    }
            
            for (int i = 1; i <= a; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    if (a % j== 0)
                    {
                        Console.WriteLine(j);
                        
                    }
                }
                
            }                                        
        }
    }



}

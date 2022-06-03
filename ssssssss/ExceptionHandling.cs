using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssssssss
{
    //WAP to use catch / handle NullReferenceRange exception.
    //WAP to catch multiple exceptions.i.IndexOutOfRangeException and DivideByZeroException
    //WAP to show use of multiple catch block with universal Exception handler.
    //WAP to create user defined Exception  and raise and catch the exception.



    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the number");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Divided my===" + a / b);
            }
            catch (DivideByZeroException obj)
            {
                Console.WriteLine("Donot enter zero");
            }
            catch (FormatException obj1)
            {
                Console.WriteLine("++++" + obj1.Message);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hallo word");
            }
        }
    }

   public class InvalidMobileExcaption : ApplicationException
    {

    }
    class MobileNo
    {

        static void Main(string[] args)
        {

            Console.WriteLine("enter the 10 dig mobile no==");
            long mno = long.Parse(Console.ReadLine());

            int count = 0;

            while (mno > 0)
            {
                count++;
                mno = mno / 10;

            }
            if (count == 10)
            {
                Console.WriteLine("this is mobile number");
            }
            else
            {
                //throw new InvalidOperationException("Logfile cannot be read-only");
                //throw new InvalidMobileExcaption();
                // InvalidMobileExcaption obj = new InvalidMobileExcaption();
                throw new InvalidMobileExcaption();
            }
        }
 
    }

    //WAP to use catch / handle NullReferenceRange exception.

    class Aa
    {
        static void Main(string[]args)
        {
            string a = null;
           
            try
            {

                Console.WriteLine(a.ToLower());
            }
            catch(NullReferenceException aa)
            {
                Console.WriteLine("+++++++++++"+aa.Message);
            }

        }
    }


    //WAP to catch multiple exceptions.i.IndexOutOfRangeException and DivideByZeroException


    class Ab
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 4,545 ,5, 7, 9 };
            int[] b = { 2, 0, 8, 0, 4 };

            for(int i=0;i<a.Length;i++)
            {
                try
                {
                    Console.WriteLine("number"+a[i]);
                    Console.WriteLine("divided by"+b[i]);
                    Console.WriteLine("ans"+a[i]/b[i]);
                
                }
                catch(DivideByZeroException ee)
                {
                    Console.WriteLine("+++++"+ee.Message);
                }
                catch(IndexOutOfRangeException ee)
                {
                    Console.WriteLine("========="+ee.Message);
                }
            }
            Console.WriteLine("dddddddd");
        }
    }
    //WAP to show use of multiple catch block with universal Exception handler.
}














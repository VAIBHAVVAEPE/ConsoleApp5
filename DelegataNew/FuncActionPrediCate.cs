using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DelegataNew
{
    //Static method
    public class Ca
    {
        public static int add(int a,int d)
        {
            int sum = a + d;
            Console.WriteLine("add" + sum);
            return sum;
            

        }
        public static int sub(int b,int c)
        {
            int sub = b - c;
            Console.WriteLine("sub"+sub);
            return sub;
            
        }

    }
    public delegate int mydel(int z,int x);
   
    class FuncActionPrediCate
    {    
        static void Main(string[] args)
        {
            mydel obj =Ca.add;
            obj += Ca.sub;
            
            obj(4, 8);
        }
    }
    //instant method
    public class Caa
    {
        public int add(int a, int d)
        {
            int sum = a + d;
            Console.WriteLine("add" + sum);
            return sum;


        }
        public int sub(int b, int c)
        {
            int sub = b - c;
            Console.WriteLine("sub" + sub);
            return sub;

        }

    }
    public delegate int mydel1(int z, int x);

    class Program1
    {
        static void Main(string[] args)
        {//only change is here
            Caa obj = new Caa();
            mydel1 fun =obj.add;
            fun +=obj.sub;
            fun(5, 6);
        }
    }



    //Static method  Anonymous method
    public class F1
    {
        //public static int add(int a, int d)
        //{
        //    int sum = a + d;
        //    Console.WriteLine("add  " + sum);
        //    return sum;
        //}
        //public static int sub(int b, int c)
        //{
        //    int sub = b - c;
        //    Console.WriteLine("sub  " + sub);
        //    return sub;
        //}
    }
    public delegate int mydelegate1(int z, int x);
    class Program2
    {
        static void Main(string[] args)
        {//anonymous method
            mydelegate1 obj = delegate (int a, int d)
            {//u can add number of method in it
                int sum = a + d;
                int sub = a - d;
                Console.WriteLine("add  " + sum);
                Console.WriteLine("sub " + sub);
                return sub;
                return sum;

            };
            obj(2, 4);
        }   
    }
    //Static method  Lambada


    public class La
    {
        //public static int add(int a, int d)
        //{
        //    int sum = a + d;
        //    Console.WriteLine("add" + sum);
        //    return sum;


        //}
        //public static int sub(int b, int c)
        //{
        //    int sub = b - c;
        //    Console.WriteLine("sub" + sub);
        //    return sub;

        //}

    }
    public delegate void myde(int z, int x);

    class Program3
    {//Static method  Lambada
        static void Main(string[] args)
        {
            myde obj = (int a, int r) =>
            {
                int e = a + r;
                Console.WriteLine(e);
            };
            obj(5, 4);
           

        }
    }

    //Generic delegate
    //1.func
    //2.Action
    //3.

    public class Fu
    {
        public static int add(int a, int d)
        {
            int sum = a + d;
            return sum;
        }
        public static int sub(int b, int c)
        {
            int sub1 = b - c;
            Console.WriteLine("diff " + sub1);
            return sub1;
        }

        // public delegate int mydel(int z, int x);//dont write this linein genertic method

        static void Main(string[] args)
        {        //func  in same Class
            Func<int, int, int> sumfunc = add;
            int sum = sumfunc(5, 3);
            Console.WriteLine("addition is " + sum);

            Func<int, int, int> subfunc = sub;
            int sub1 = subfunc(7, 2);
        }

    }

    public class Fu1
    {
        //public static int add(int a, int d)
        //{
        //    int sum = a + d;
        //    return sum;
        //}
        //public static int sub(int b, int c)
        //{
        //    int sub1 = b - c;
        //    Console.WriteLine("diff " + sub1);
        //    return sub1;
        //}

        // public delegate int mydel(int z, int x);//dont write this linein genertic method
        //public delegate int mydelegate1(int z, int x);
        static void Main(string[] args)
        {
            //anonymous func
            Func<int, int, int> Addfunc = delegate (int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("sum " + sum);
                return sum;

            };
            Addfunc(5, 6);


        }

    }
    public class Fu11
    {
        //public static int add(int a, int d)
        //{
        //    int sum = a + d;
        //    return sum;
        //}
        //public static int sub(int b, int c)
        //{
        //    int sub1 = b - c;
        //    Console.WriteLine("diff " + sub1);
        //    return sub1;
        //}

        // public delegate int mydel(int z, int x);//dont write this linein genertic method

        static void Main(string[] args)
        {
            //Lambda in func
            Func<int, int, int> Addfunc = (a,b) =>
             {
                 int sum = a + b;
                 Console.WriteLine("sum " + sum);
                 return sum;
                
             };
            Addfunc += (x, y) =>
             {
                 int prod = x * y;
                 Console.WriteLine("prod =" + prod);
                 return prod;
             };
            Addfunc(5, 6);
            
           


        }

    }









    public class Au2
    {
        public static void add(int a, int d)
        {
            int sum = a + d;
            Console.WriteLine("Add " + sum);
        }
        public static void sub(int b, int c)
        {
            int sub = b - c;
            Console.WriteLine("sub" + sub);

        }

    }

    class Program11
    {     //Action  Class is Different
        static void Main(string[] args)
        {
            Action<int, int> sumAction = Au2.add;
            sumAction(5, 4);


            Action<int, int> subAction = Au2.sub;
            subAction(7, 3);
            //Lambda in Action
            Console.WriteLine("Lambda in Action");
               Action<int, int> ProductAction = (int a, int b) =>
               {
                   Console.WriteLine("Product " + a * b);
                   
               };
            ProductAction(4,6);

            //Action<int, int, int> add = (int a, int b, int c) => a + b + c;


        }


    }
    class Predicate
    {
        public static bool b;
        static void Main(string[] args)
        {

        }

    }
    
}

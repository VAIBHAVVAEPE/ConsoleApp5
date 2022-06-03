using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{

    class Movie
    {
        string moviename;
        string director;
        string producer;
        int rating;

         public void Setmoviename(string name)
        {
            moviename = name;   
        }
        public string Getmoviename()
        { 
            return moviename;   
        }
        public void Setdirector(string dir)
        {
            moviename = dir;
        }
        public string Getdirector()
        { 
            return  director;
        }
        public void Setproducer(string pro)
        {
            moviename = pro;
        }
        public string Getproducer()
        {
            return producer;
        }
        public void Setrating(int ret)
        {
            rating = ret;
        }
        public int Getrating()
        {
            return rating;
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Movie a1=new Movie();
            a1.Setmoviename("vai");
            a1.Setproducer("ram");
            a1.Setdirector("sham");
            a1.Setrating(4);
            Console.WriteLine(" movieName=" + a1.Getmoviename());
            Console.WriteLine(" director=" + a1.Getdirector());
            Console.WriteLine(" Produce=" + a1.Getproducer());
            Console.WriteLine("reting =" + a1.Getrating());




            //Console.WriteLine($"moviename={a1.Getmoviename()} produce={a1.Getproducer()}director={a1.Getdirector()} rating={a1.Getrating()}");

                          
            Console.WriteLine("enter name movienam, director,producer ,rating");
            Movie a2 = new Movie();
            a2.Setmoviename(Console.ReadLine());
            a2.Setdirector(Console.ReadLine());
            a2.Setproducer(Console.ReadLine());
            a2.Setrating(Convert.ToInt32(Console.ReadLine()));

           
            Console.WriteLine(" movieName" + a2.Getmoviename());
            Console.WriteLine(" director" + a2.Getdirector());
            Console.WriteLine(" Produce" + a2.Getproducer());
            Console.WriteLine("reting" + a2.Getrating());

          // Console.WriteLine($"moviename={a2.Getmoviename} director={a2.Getdirector} produce={a2.Getproducer} rating={a2.Getrating}");

        }
    }
}

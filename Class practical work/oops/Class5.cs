using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{
    class DemoPen
    {
        string name;
        string color;
        int price;

        public DemoPen() 
            {
            Console.WriteLine("don pen");
             }
        public DemoPen(string na, string col)
        {
            name=na;
            color=col;
        }
            
        public void setname(string name)
        {
             this.name = name;
        }
        public string getname()
        { 
            return name; 
        }
        public void setcolor(string co)
        {
            color = co;
        }
        public string getcolor()
        {
            return color;
        }
        public void setprice(int pr)
        {
            price = pr;
        }
        public int getprice()
        {
            return price;
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            DemoPen obj = new DemoPen();
            obj.setname("Vaibhav");
            obj.setcolor("red");
            obj.setprice(55);

            Console.WriteLine("This Is Name " + obj.getname());
            Console.WriteLine("This Is Color " + obj.getcolor());
            Console.WriteLine("This Is Price " + obj.getprice());

            Console.WriteLine();
            DemoPen obj1 = new DemoPen();
            Console.WriteLine("Enter Name");
            obj1.setname(Console.ReadLine());
            Console.WriteLine("Enter Color");
            obj1.setcolor(Console.ReadLine());
            Console.WriteLine("Enter Price");
            obj1.setprice(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Name = " + obj1.getname());
            Console.WriteLine("Color = " + obj1.getcolor());
            Console.WriteLine("Price = " + obj1.getprice());


            //DemoPen obj2 = new DemoPen();
            


            Console.ReadLine(); 
        }
    }
}

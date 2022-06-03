using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{
    class Book 
    {
        public string bookname;
        public int rate, yearofpublish;
        public string author;

    }
    internal class Tbook
    {
        static void main(string[] arg)
        {
            Book a1 = new Book();
            a1.bookname = "vaibhav";
            a1.rate = 200;
            a1.yearofpublish = 2010;
            a1.author = "ram";
            Console.WriteLine($"bookname={a1.bookname} rate={a1.rate}author={a1.author} yrarofpublish={a1.yearofpublish}");

            Book b2 = new Book();
            Console.WriteLine(" bookname ,author,rate,yearofpublish");
            b2.bookname = Convert.ToString(Console.ReadLine());
            b2.author = Convert.ToString(Console.ReadLine());
            b2.rate = Convert.ToInt32(Console.ReadLine());
            b2.yearofpublish = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"bookname={b2.bookname} rate={b2.rate}author={b2.author} yrarofpublish={b2.yearofpublish}");

        }
    }


}

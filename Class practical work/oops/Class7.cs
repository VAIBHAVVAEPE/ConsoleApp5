using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{
    class Country
    {
        string countryname;
        int states;
        int nooflanguage;

        public string Countryname
        { 
            get { return countryname; }
            set { countryname = value; }
        }
        public int State
        {
            get { return states; }
            set { states = value; }
        }
        public int Nooflanguage
        {
            get { return nooflanguage; }
            set { nooflanguage = value; }
        }
    }
    internal class Class7
    {
        static void Main(string[] args)
        {
            Country c=new Country();
            c.Countryname="ddddd";
            c.Nooflanguage=12;
            c.State=10;
            Console.WriteLine(c.Countryname);
            Console.WriteLine(c.State);
            Console.WriteLine(c.Nooflanguage);
        }
    }
}

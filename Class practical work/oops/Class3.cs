using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{

    class Voter
    {
        long adharcard;
        string votername;
        string votecast;

        public void Setadharcard (long card)
        {
            adharcard = card;
        }
        public long Getadharcard()
        {
           return adharcard;
        }
        public void Setvotername (string name)
        {
            votername = name;
        }
        public string Getvotername()
        {
            return votername;
        }
        public void Setvotecaste(string caste)
        {
            votecast = caste;
        }
        public string Getvotecast()
        {
            return votecast;
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {

            Voter a1 = new Voter();
            a1.Setvotername("vaibhav");
            a1.Setvotecaste("bgp");
            a1.Setadharcard(1213556355);



            Console.WriteLine("name of voter" + a1.Getvotername());
            Console.WriteLine("name of cast" + a1.Getvotecast());
            Console.WriteLine("number of adhar"+a1.Getadharcard());


        }
    }
}

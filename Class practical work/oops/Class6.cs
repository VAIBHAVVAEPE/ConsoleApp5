using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_practical_work.oops
{

    class Account
    {
        string accountname;
        float accountbalance;

        public void setaccountname(string nsme)
        {
            accountname = nsme; 
        }
        public string getaccountname()
        { 
            return accountname;
        } 
        public void setaccountbalance(float bal)
        {
            accountbalance = bal;
        }
        public float getaccountbalance()
        {
            return accountbalance;
        }

    }
    internal class Class6
    {
        static void Main(string[] args)
        {
            Account obj=new Account();
            obj.setaccountbalance(123254);
            obj.setaccountname("ram");


            Console.WriteLine("This Is Name " + obj.getaccountname());
            Console.WriteLine(" balance is"+obj.getaccountbalance);

        }
    }
}

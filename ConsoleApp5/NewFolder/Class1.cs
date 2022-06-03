using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.NewFolder
{
    class Teacher
    {
       
        int tid;
        String tName;
        long mob;
        public Teacher(int tid, String tName, long mob)
        {
            this.tid = tid;
            this.tName = tName;
            this.mob = mob;

            Console.WriteLine("Teacher Id:" + tid);
            Console.WriteLine("Teacher Name:" + tName);
            Console.WriteLine("Mobile no. " + mob);
        }
        public Teacher()
        {

        }
    }
    class HourlyBased : Teacher
    {
        int ratePerHr;
        int hrs;
        public HourlyBased(int tid, String tName, long mob, int ratePerHr, int hrs) : base(tid, tName, mob)
        {
            this.ratePerHr = ratePerHr;
            this.hrs = hrs;
            Console.WriteLine("Rate Per Hour:" + ratePerHr);
            Console.WriteLine("Hours: " + hrs);
            Salary();
        }
        public void Salary()
        {
            Console.WriteLine("Salary:" + ratePerHr * hrs);
            Console.WriteLine();
        }
    }
    class SalaryBased : Teacher
    {
        int salary;
        public SalaryBased(int tid, String tName, long mob, int salary) : base(tid, tName, mob)
        {

            this.salary = salary;
            Salary();
        }
        public void Salary()
        {
            Console.WriteLine("Salary:" + salary);
            Console.WriteLine();

        }

    }
    class Class1
    {
        static void Main(string[] args)
        {
            HourlyBased h = new HourlyBased(100, "ram", 8149881587, 500, 50);
            SalaryBased s = new SalaryBased(101, "Shubham", 9090909090, 50000);

        }
    }



    //Containment



    class School
    {
        int stid;
        string stname;
        string staddre;
         Teacher info=new Teacher();

        public int Stid { get => stid; set => stid = value; }
        public string Stname { get => stname; set => stname = value; }
        public string Staddre { get => staddre; set => staddre = value; }
        internal Teacher Info { get => info; set => info = value; }
        public School()
        {

        }

    }
  
        

        
    
    class Ttester
    {
        static void Main(string[] args)
        {
            School s=new School();  
            
            
        }
    }
}

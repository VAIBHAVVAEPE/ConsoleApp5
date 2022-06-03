using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System;

namespace ssssssss
{//1.	WAP to sort the elements of List that contains String objects. Print List.
   
    class Student:IComparable<Student>
    {
        string name;

        public Student(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);

        }
        public override string ToString()
        {
            return $"Student => {name}";
        }

    }
    internal class CollectionAss2
    {
        static void Main(string[] args)
        {
            List<Student> al = new List<Student>();
            al.Add(new Student("Vaibhav"));
            al.Add(new Student("Ram"));
            al.Add(new Student("Sham"));
            al.Add(new Student("Ajinkay"));
            al.Add(new Student("Sahil"));
            al.Add(new Student("Shubham"));
            al.Add(new Student("Ganesh"));
            al.Add(new Student("00"));

            foreach (var aa in al)
            {
                Console.WriteLine(aa);
            }
            Console.WriteLine("////////////");

            al.Sort();
            foreach (var a1 in al)
            {
                Console.WriteLine(a1);
            }

        }

    }
    //2.WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List.
    class Employee:IComparable<Employee>
    {
        string name;
        string designation;
        int salary;

        public Employee(string name, string designation, int salary)
        {
            this.Name = name;
            this.Designation = designation;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public int CompareTo(Employee obj)
        {
            return this.Name.CompareTo(obj.name);
            return this.Designation.CompareTo(obj.designation);
            return this.Salary.CompareTo(obj.salary);
        }
        public override string ToString()
        {
            return $"Name={name}   Designation={designation}   Salary={salary}";
        }
    }
    class MainProgrem
    {
        static void Main(string[] args)
        {
            List<Employee> em =new List<Employee>();
            em.Add(new Employee("Vaibhav", "CEO", 80000));
            em.Add(new Employee("Ram", "CAA", 90000));
            em.Add(new Employee("Varpe", "CEEO", 5500));
            em.Add(new Employee("Sham", "CAAo", 43000));
            em.Add(new Employee("a", "CCEO", 18000));
            em.Add(new Employee("Sahil", "ACAA", 90000));
            em.Add(new Employee("Vaibhavi", "CEoO", 80000));
            em.Add(new Employee("Prasd", "CKKAA", 90000));
           
            foreach(dynamic aa in em)
            {
                Console.WriteLine(aa);
            }


        }
    }
    //3.	WAP to create a Queue with some colors (String) using generics.
    class Colors
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Red");
            q.Enqueue("Blue");
            q.Enqueue("Black");
            q.Enqueue("White");
            q.Enqueue("Green");
            q.Enqueue("yellow");

            q.Dequeue();
            

            foreach (dynamic aa in q)
            {
                Console.WriteLine(aa);
            }
            

            
            
        }
    }
    //4.	WAP to add user defined objects of type Employee in a HashSet employee object.
    //Make sure if I create 2 different objects with same data the other one should not be added as hashset stores unique objects.

    class HashSetExample
    {
        static void Main(string[] args)
        {
            HashSet<object> hs = new HashSet<object>();
            hs.Add(new Employee("suraj", "sr.developer", 25000));
            hs.Add(new Employee("amit", "project lead", 50000));
            hs.Add(new Employee("ritik", "QA", 20000));
            hs.Add(new Employee("suraj", "jr.developer", 15000));
            hs.Add(new Employee("suraj", "sr.developer", 25000));

            foreach (dynamic d in hs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            for (int i = 0; i < hs.Count; i++)
            {
                Console.WriteLine();
            }
        }
    }

   
   // 5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.

}

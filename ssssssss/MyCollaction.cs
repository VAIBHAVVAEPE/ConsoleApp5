using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ssssssss
{
    internal class MyCollaction
    {
        static void Main(string[] args)
        {

            ArrayList a1 = new ArrayList();

            a1.Add(90);
            a1.Add("Vaibhav");
            a1.Add('v');
            // a1.Add(true);
            a1.Add('v');
            a1.Add("RAm");
            a1.Add(9075);
            a1.Remove('v');
            a1.Insert(2, 111111);
            a1.RemoveAt(1);
            a1.Reverse();



            for (int i = 0; i < a1.Count; i++)
            {
                Console.WriteLine("Count" + a1.Count + "   " + a1[i]);

            }
            Console.WriteLine("Capacity= " + a1.Capacity);
            Console.WriteLine("Count= " + a1.Count);
            Console.WriteLine(a1.Contains('v'));
        }
    }


    /*1.	Assume you have Arraylist  al = new ArrayList ();
    al.Add("Sun");
         al.Add("Mon");
         al.Add("Sat");
         al.Add("Sun ");
         al.Add("Mon ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Sat ");
         al.Add("Sun ");
         al.Add("Mon ");
         Write a code to remove duplicate elements from above list.
         Final Arraylist should contain (Sun, Mon, Sat);*/

    class Class12
    {
        static void Main(string[] args)
        {

            ArrayList a11 = new ArrayList();
            a11.Add("Sun ");
            a11.Add("Mon ");
            a11.Add("Sat ");
            a11.Add("Sun ");             //sun=4,,mon=3,,sat=3
            a11.Add("Mon ");
            a11.Add("Sat ");
            a11.Add("Sun ");
            a11.Add("Sat ");
            a11.Add("Sun ");
            a11.Add("Mon ");



            //            (or)
            //for(int i=0;i<a11.Count;i++)
            //{
            //    string ss =(string) a11[i];
            //    while (a11.IndexOf(ss) != a11.LastIndexOf(ss))
            //        {
            //        int last = a11.LastIndexOf(ss);
            //        a11.RemoveAt(last);
            //    }

            //}
            //         (0r)
            for (int i = 0; i < a11.Count; i++)
            {
                //Console.WriteLine(i);
                for (int j = i + 1; j < a11.Count; j++)
                {
                    if (a11[i] == a11[j])
                    {
                        // a11.RemoveAt(i);
                        a11.RemoveAt(j);
                        j--;
                    }
                    // j--;
                }

            }
            foreach(var a in a11)
            {
                Console.WriteLine(a);
            }
            for (int i = 0; i < a11.Count; i++)
            {
                Console.WriteLine(a11[i]);
            }


        }
    }
    class Class13
    {
        //2 Sort Arraylist of String in reverse order of its natural sorting.


        static void Main(string[] args)
        {
            ArrayList a11 = new ArrayList();
            a11.Add("B");
            a11.Add("D");
            a11.Add("C");
            a11.Add("A");
            a11.Add("E");
            a11.Add("F");
            a11.Add("J");
            a11.Add("G");
            a11.Add("V");
            a11.Add("P");
            // a11.Reverse();
            Console.WriteLine("Befour Sort");
            for (int i = 0; i < a11.Count; i++)
            {
                Console.Write(a11[i] + " ");
            }
            Console.WriteLine();
            Console.Write("After Sort");
            Console.WriteLine();
            a11.Sort();
            a11.Reverse();

            foreach (var aa in a11)
            {
                Console.Write(aa + " ");

            }
            //Console.WriteLine();
            //Console.Write("Reverse");
            //Console.WriteLine();

            //for (int j = 0; j < a11.Count; j++)
            //{
            //    a11.Sort();
            //    a11.Reverse();
            //}
            //foreach (var aa in a11)
            //{
            //    Console.Write(aa + " ");

            //}




        }
    }

    class Class33
    {//booble sort
        static void Main(string[] args)
        {
            int[] Arr = { 6, 4, 2, 76, 43, 2, 1 };

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Arr[i] > Arr[j])
                    {
                        int temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Arr[i]);
            }

        }
    }

    //    3.	 The encryption of alphabets are to be done as follows:	[2]

    //    A=1,B=2,C=3,Z=26

    //The potential of a word is found by adding the encrypted value of the alphabets.

    //Example: KITE

    //Potential = 11 + 9 + 20 + 5 = 45

    //Accept a sentence Decode the words according to their potential and arrange them in ascending order.

    //Output the result in format given below:
    // Input:THE SKY IS THE LIMIT.
    // POTENTIAL:THE= 33, SKY= 55, IS= 28, THE= 33, LIMIT= 63
    //Output :IS THE THE SKY LIMIT


    class Encryption
    {
        static void Main(string[] args)
        {
            string arr = "THE SKY IS THE LIMIT";
            string[] arr2 = arr.Split();

            int[] aa = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                //Console.WriteLine(arr2[i]);
                char[] ch = arr2[i].ToCharArray();
                int sum = 0;
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.WriteLine(ch[j]);
                    if (ch[j] >= 65 && ch[j] <= 90)
                    {
                        sum = sum + (ch[j] - 64);

                    }

                }
                //Console.WriteLine(arr2[i]+" sum "+sum);
                aa[i] = sum;
                Console.WriteLine(aa[i]);
            }

            Console.WriteLine("///////");
            for (int j = 0; j < aa.Length; j++)
            {
                for (int k = j + 1; k < aa.Length; k++)
                {
                    if (aa[j] > aa[k])
                    {
                        string temp1 = arr2[j];
                        arr2[j] = arr2[k];
                        arr2[k] = temp1;

                        int temp = aa[j];
                        aa[j] = aa[k];
                        aa[k] = temp;
                    }
                }
            }
            for (int j = 0; j < aa.Length; j++)
            {
                Console.WriteLine(arr2[j] + "  " + aa[j]);
            }

        }
    }

    //    4.	Create ArrayList of T20 Players.

    //Create a class Player (playerid, Name, Country, team)
    //e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)
    //Then find out which team has maximum Australian players.


    class Player
    {
        int playerid;
        string name;
        String country;
        String team;

        public Player(int playerid, string name, string country, string team)
        {
            this.playerid = playerid;
            this.name = name;
            this.country = country;
            this.team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        {
            return "pid:" + Playerid + " " + "player name:" + Name + " " + "country:" + Country + " " + "Team:" + Team;
        }

    }
    class T20
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(new Player(1, "Dhoni", "India", "CSK"));
            a1.Add(new Player(2, "Glenn", "Australian", "RCB"));
            a1.Add(new Player(3, "Virat", "India", "RCB"));
            a1.Add(new Player(6, "ABD", "Australian", "RCB"));
            a1.Add(new Player(4, "Aron", "Australian", "CSK"));
            a1.Add(new Player(5, "Surya", "India", "GT"));
            a1.Add(new Player(7, "FAB", "Australian", "Csk"));
            a1.Add(new Player(9, "Mahindra", "India", "Csk"));
            a1.Add(new Player(7, "FAwwwwB", "Australian", "Csk"));
            a1.Add(new Player(7, "FwwwwdAB", "Australian", "Csk"));

            string max_teamname = "";
            int maxcount = 0;
            foreach (Player p in a1)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player p1 in a1)
                {
                    if (p1.Team == t && p1.Country == "Australian")
                    {
                        c++;
                    }
                }
                if (maxcount < c)
                {
                    max_teamname = p.Team;
                    maxcount = c;
                }
            }
            Console.WriteLine($"Maximum Australian player in {max_teamname}={maxcount} ");
        }
    }

    //  5.	Write a program to get the value of a specified key in a HashTable
    //and also update the value for given key.

    class Class22
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add('a', "Apple");
            ht.Add('b', "BadaApple");
            ht.Add('c', "ChotaApple");
            ht.Add('d', "DoubleApple");


            foreach (var AA in ht.Keys)
            {
                Console.WriteLine("keys  :" + AA + " Value :" + ht[AA]);
            }
            ht['d'] = "DogApple";
            Console.WriteLine("Updated Value");

            foreach (DictionaryEntry BB in ht)
            {
                Console.WriteLine(BB.Key + ";;" + BB.Value + ";;");
            }


        }
    }

    //6.	Write a program to get a set of keys contained in HashTable and print whole HashTable using for each loop.

    
             





    //7.	Create a HashTable where key is integers 1 to 10 and string is number in Words.
    //Remove entry for which number is divisible by 3.

    class Class122
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");

            foreach (dynamic n in ht.Keys)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(" " + n + " " + ht[n]);
                }
            }

            //Console.WriteLine("/////");

            //foreach(object a in ht.Keys)
            //{
            //    int data = (int)a;
            //    if(data%2==0)
            //    {
            //        Console.WriteLine(data+" "+ ht[data]);
            //    }
            //}
            //Console.WriteLine("/////");
            //foreach(DictionaryEntry e in ht)
            //{
            //    int data = (int)e.Key;
            //    if(data>=6)
            //    {
            //        Console.WriteLine(e.Key + " " + e.Value);
            //    }
            // }

        }
    }

    //    8.	ArrayList Contains
    //al.Add("pune");
    //al.Add("Mumbai");
    //al.Add("pune");
    //al.Add("Mumbai");
    //al.Add("Nasik");
    //al.Add("pune");
    //Create a HashTable which contain String as key and Integer as value key is name of city and value is frequency of that city.
    //("pune",3);
    //    ("Mumbai",2);
    //Print hashtable using Foreach loop.


    class Class132
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");


            Hashtable ht = new Hashtable();

            //foreach(dynamic v in al)
            //{
            //    if(ht.ContainsValue(v))
            //    {
            //        int oldkey=ht[v.ToString()];
            //        ht[v] = oldkey + 1;
            //    }
            //    else
            //    {
            //        ht.Add(1, v);
            //    }
            //}






            foreach (dynamic k in al)
            {
                if (ht.ContainsKey(k))
                {
                    int oldvalue = ht[k];
                    ht[k] = oldvalue + 1;

                }
                else
                {
                    ht.Add(k, 1);
                }
            }
            foreach (dynamic h in ht.Keys)
            {
                Console.WriteLine(h + " " + ht[h]);
            }



        }



        //    3.	 The encryption of alphabets are to be done as follows:	[2]

        //    A=1,B=2,C=3,Z=26

        //The potential of a word is found by adding the encrypted value of the alphabets.

        //Example: KITE

        //Potential = 11 + 9 + 20 + 5 = 45

        //Accept a sentence Decode the words according to their potential and arrange them in ascending order.

        //Output the result in format given below:
        // Input:THE SKY IS THE LIMIT.
        // POTENTIAL:THE= 33, SKY= 55, IS= 28, THE= 33, LIMIT= 63
        //Output :IS THE THE SKY LIMIT

    }
        class Class65
        {
            static void Main(string[] args)
            {
                Console.WriteLine("ajay".CompareTo("adi"));

            Stack st=new Stack();
            st.Push(12);
            st.Push(13);    
            st.Push(14);

            Console.WriteLine(  );
            }

        }

    
}












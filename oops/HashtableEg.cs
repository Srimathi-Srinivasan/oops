using System;
using System.Collections;

namespace oops
{
    internal class HashtableEg
    {
        public static void main()
        {
            Hashtable ht = new Hashtable();
            #region
            //ht.Add(1, "Sri");
            //ht.Add(2, "Mathi");
            //ht.Add(3, null);
            
            //foreach(DictionaryEntry de in ht)
            //{
            //    Console.WriteLine(de.Key+":"+de.Value);

            //}
            #endregion

            ht.Add("1001", new Emp(1, "Sri"));
            ht.Add("1002", new Emp(2, "Mathi"));

            foreach (Emp val in ht.Values)
            {
                Console.WriteLine(val.ToString());
            }
            Console.WriteLine("Enter the key to be searched: ");
            string search = Console.ReadLine();
            if (ht.ContainsKey(search))
            {
                Console.WriteLine(ht[search]);
            }

            if (ht.Contains(search))
            {
                Console.WriteLine(ht[search]);
            }
        }



    }

    internal class Emp
    {
        public int eid;
        public string ename;

        public Emp()
        {

        }

        public Emp(int Eid, string Ename)
        {
            eid = Eid;
            ename = Ename;
        }

        public override string ToString()
        {
            return String.Format(eid + ":" + ename);
        }

    }
}

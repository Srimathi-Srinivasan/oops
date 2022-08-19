using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class HashSet
    {
        public static void Main()
        {
            List<string> lst = new List<string>();
            lst.Add("Chennai");
            lst.Add("Bangalore");
            lst.Add("Mumbai");
            lst.Add("Chennai");
            lst.Add("Bangalore");
            lst.Add("Mumbai");

            foreach(string item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------------------------");


            HashSet<string> hs = new HashSet<string>();
            hs.Add("Chennai");
            hs.Add("Bangalore");
            hs.Add("Mumbai");
            hs.Add("Chennai");
            hs.Add("Bangalore");
            hs.Add("Mumbai");

            foreach (string item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}

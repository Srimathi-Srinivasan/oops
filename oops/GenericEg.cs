using System;
using System.Collections.Generic;


namespace oops
{
    internal class GenericEg
    {
        public static void main()
        {
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(2);

            foreach(int item in l)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Apple");
            dic.Add(2, "Mango");

            foreach(KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("Enter the search key: ");
            int search = Convert.ToInt32(Console.ReadLine());
            if(dic.ContainsKey(search))
            {
                Console.WriteLine(dic[search]);
            }
            else
            {
                Console.WriteLine("Sorry! item not found");
            }
        }
        
    }
}

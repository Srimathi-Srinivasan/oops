using System;
using System.Collections;

namespace oops
{
    internal class ArrayListEg
    {
        public static void main()
        {
            #region

            //int[] arr = new int[] { 1, 2, 3 };
            //// int[] arr = new int[]; - error

            //int[] arr1 = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(arr1[i]);

            //}
            #endregion

            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("hello");
            al.Add(true);
            al.Add(67.89f);

            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(al.Count);
            al.Remove(true);
            al.Insert(2, 34);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

        }
    }
}
